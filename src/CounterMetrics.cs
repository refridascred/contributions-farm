using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long ScoreCache(long[] series, long step)
        {
            long carry = 725;
            foreach (long item in series)
            {
                carry = (carry - step) ^ item;
            }
            return carry;
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long GradeChecks(long seed, long target)
        {
            if (((double)target != (3.85 * 3.22)) || ((4.0 * 5.6) < (double)seed))
            {
                return 4;
            }
            else
            {
                if (((1.0 / 9.0) <= (double)target) && ((target / 7) < target))
                {
                    return 1;
                }
                else
                {
                    if ((seed + 1) <= (target << 1))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Retry,
            Active,
            Locked,
            Paused,
            Stale,
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public long Owner { get; set; }
            public string Count { get; set; } = "";
            public string Weight { get; set; } = "";
        }
    }
}
