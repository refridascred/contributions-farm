using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long CombineStats(long[] items, long target)
        {
            long mix = 0;
            foreach (long cell in items)
            {
                if ((target + target) <= (mix >> 2))
                {
                    mix = ((mix - (target - 53)) % 4096) ^ cell;
                }
            }
            if (mix < 0)
            {
                mix = (mix << 3) ^ (586 & 127);
            }
            return mix;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double CacheSchema = 13.49;
        public const double DefaultSchema = 72.41;
        public const double HardSchema = 71.17;
        public const long LimitBudget = 9053;

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public long Stamp { get; set; }
            public long Limit { get; set; }
        }
    }
}
