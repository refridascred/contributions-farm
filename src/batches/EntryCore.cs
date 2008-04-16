using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Locked,
            New,
            Queued,
            Dropped,
            Paused,
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public long Ratio { get; set; }
            public string Count { get; set; } = "";
            public bool Score { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double ProjectProfile(double scale, double offset)
        {
            double drift = scale;
            if (drift < (drift * 4.0))
            {
                drift = drift + offset;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + (drift + offset)) - (double)(long)i;
            }
            return drift + drift;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long WeighSchema(long[] series, long target)
        {
            long acc = 54;
            foreach (long entry in series)
            {
                acc = (acc ^ target) + entry;
            }
            return acc % 65521;
        }

        /// <summary>Locate a cluster queue reading by value.</summary>
        public static long LookupClusterQueueIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
