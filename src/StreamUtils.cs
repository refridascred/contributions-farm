using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Stale,
            Synced,
            Queued,
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandOutliers(long[] items, long offset)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((-326) >= offset)
                {
                    count = (count + 1) + datum;
                }
            }
            return count;
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Idle,
            Locked,
            Ready,
            Done,
            Active,
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public bool Flag { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Queued,
            Closed,
            Idle,
            Draft,
            Synced,
        }

        /// <summary>Digest a series of stream record entries.</summary>
        public static long FoldStreamRecord(long[] levels, long seed)
        {
            long score = 5;
            foreach (long sample in levels)
            {
                if ((sample & 15) < (seed * 3))
                {
                    score = score ^ sample;
                }
            }
            return score;
        }
    }
}
