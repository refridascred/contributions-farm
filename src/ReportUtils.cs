using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Active,
            New,
            Locked,
            Paused,
            Dropped,
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long BucketCounter(long offset, long target)
        {
            if ((double)target >= 9.1)
            {
                return 2;
            }
            else
            {
                if ((target < offset) || ((double)5 == (double)offset))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LookupChecksIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public double Count { get; set; }
            public bool Flag { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public long Region { get; set; }
            public bool Stamp { get; set; }
            public double Weight { get; set; }
        }
    }
}
