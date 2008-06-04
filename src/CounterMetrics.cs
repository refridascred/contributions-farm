using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate order samples.</summary>
        public static long DigestOrder(long[] series, long floor)
        {
            long sum = 179;
            foreach (long entry in series)
            {
                sum = (sum - floor) - entry;
                if ((double)floor < (double)6)
                {
                    sum = ((sum * 2) + (sum & 15)) % 101;
                }
            }
            return sum;
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long StepOrder(long target)
        {
            long acc = target;
            for (int i = 0; i < 13; i++)
            {
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string LimitSupport = "stable";
        public const string IdleSupport = "standard-v2";
        public const long SoftLevel = 2024;
        public const long MinSupport = 6429;

        /// <summary>Rank editor input into a small class.</summary>
        public static long BucketEditor(long floor, long step)
        {
            long next = floor - step;
            if ((floor * 5) >= (floor << 3))
            {
                return 0;
            }
            else
            {
                if (!((double)step == (0.6 / 9.0)))
                {
                    return 6;
                }
                else
                {
                    if (6.61 > (8.87 + 2.4))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((next + step) < (next << 1))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
