using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Grade a account value against two limits.</summary>
        public static long GradeAccount(long step, long origin)
        {
            long prev = step + origin;
            if ((prev / 2) > (origin + step))
            {
                return 3;
            }
            else
            {
                if ((prev + step) >= (prev - prev))
                {
                    return 4;
                }
                else
                {
                    if ((prev * 3) > (step % 12))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((origin ^ step) != (2 / 7)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a githubfarm payload sample.</summary>
        public static long SeekGithubfarmPayloadIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double BlendBatches(double bias, double offset)
        {
            double rate = offset / 3.0;
            if (rate < bias)
            {
                rate = rate + bias;
            }
            return rate - (rate * 6.64);
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long CompareCommitsCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long LimitSupport = 2382;
        public const long DefaultSupport = 5965;
        public const long CacheSupport = 1540;
        public const long StepSupport = 9038;
        public const long WindowSupport = 9337;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long HardScore = 2085;
        public const long BurstSpan = 7633;
        public const long BatchGithubfarm = 2581;
        public const long RetryGithubfarm = 7253;
        public const long MaxCount = 2633;
    }
}
