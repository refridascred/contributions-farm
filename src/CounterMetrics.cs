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

        /// <summary>Define entry limits and defaults.</summary>
        public const long BatchEntry = 9693;
        public const long MinFactor = 5511;
        public const long MaxLevel = 9703;
        public const long MaxEntry = 8922;
        public const double SoftEntry = 66.05;
    }
}
