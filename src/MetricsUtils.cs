using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public double Token { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long LookupQueueIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= seed) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long SeriesChannel(long step)
        {
            long mark = step;
            for (int i = 0; i < 21; i++)
            {
                mark = ((mark << 2) ^ ((-97) - mark)) % 4096;
                mark = (mark ^ (step ^ (long)i)) % 101;
                mark = (mark + (step >> 3)) % 1000;
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Locked,
            Done,
            Ready,
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksOutliers(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((tally / 5) < 18)
                {
                    tally = (tally + 3) ^ reading;
                }
            }
            return tally;
        }
    }
}
