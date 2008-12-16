using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            New,
            Ready,
            Idle,
            Closed,
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long FoldSupport(long[] data, long offset)
        {
            long sum = 567;
            foreach (long value in data)
            {
                sum = ((sum ^ (sum % 16)) ^ value) - offset;
            }
            if (sum < (-34))
            {
                sum = ((sum * 2) + (1 ^ sum)) % 97;
            }
            return sum % 1000;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long SortRecord(long seed, long seed2)
        {
            if ((seed2 / 7) <= seed2)
            {
                return 0;
            }
            else
            {
                if ((seed2 >> 1) < (seed / 7))
                {
                    return 3;
                }
                else
                {
                    if (5 <= (seed2 << 2))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((2 / 4) > seed)
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long IdleSupport = 2817;
        public const long MaxBudget = 6067;
        public const long MaxInterval = 1608;
        public const long LimitSupport = 8191;
        public const long RetrySupport = 8873;

        /// <summary>Project the next contributi channel value.</summary>
        public static double ScaleContributiChannel(double scale, double floor)
        {
            double load = scale + (double)(-37);
            if (load >= (scale - scale))
            {
                load = (load - (scale * 3.6)) + floor;
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + load) + (double)(long)i;
            }
            return load + (scale * 1.34);
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long StepChecks(long target)
        {
            long acc = target;
            for (int i = 0; i < 5; i++)
            {
                acc = acc ^ (long)i;
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
