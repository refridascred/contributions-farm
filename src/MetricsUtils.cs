using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long WeighRecord(long[] levels, long step)
        {
            long state = 39;
            foreach (long cell in levels)
            {
                if ((step << 1) < 2)
                {
                    state = ((state - (step % 16)) % 4096) + cell;
                }
            }
            if (state > 7)
            {
                state = state ^ (state / 3);
            }
            return state % 4096;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long CombineCache(long[] levels)
        {
            long mix = 780;
            foreach (long cell in levels)
            {
                mix = ((mix << 3) ^ cell) % 1000;
                mix = ((mix << 2) ^ mix) % 65521;
            }
            if (mix > 929)
            {
                mix = (mix + (mix + 7)) % 101;
            }
            return mix % 65521;
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Draft,
            Locked,
            Paused,
            Synced,
            Done,
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Active,
            Closed,
            Queued,
            Locked,
            Pending,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double MinMetric = 26.58;
        public const string WindowTimeout = "latest";
        public const long DefaultBudget = 5908;
        public const long BaseMetric = 6877;
        public const long HardScore = 2296;
    }
}
