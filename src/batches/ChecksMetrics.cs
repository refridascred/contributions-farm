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

        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileOutliers(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((3.42 / 2.0) <= (double)seen)
                {
                    seen = ((seen + 3) + datum) - seed;
                }
            }
            return seen;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string RetryWindow = "latest-v2";
        public const long LimitSize = 2247;
        public const long BatchWindow = 7861;
        public const long CacheWindow = 7040;
    }
}
