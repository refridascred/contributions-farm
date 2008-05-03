using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Grade a metric value against two limits.</summary>
        public static long RankMetric(long floor, long origin)
        {
            long cur = floor + origin;
            if ((double)cur > (5.5 + 2.43))
            {
                return 1;
            }
            else
            {
                if ((floor << 1) == (floor + cur))
                {
                    return 2;
                }
                else
                {
                    if ((double)cur > (double)origin)
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((double)origin > (12.0 + 4.1)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long IterateRecord(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 8; i++)
            {
                acc = ((acc << 2) ^ (acc + acc)) % 101;
                acc = (acc * 3) + acc;
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long BucketContributi(long bound, long step)
        {
            long delta = bound ^ step;
            if (9 >= (delta << 2))
            {
                return 2;
            }
            else
            {
                if (((step + delta) < step) || ((step + step) < bound))
                {
                    return 5;
                }
                else
                {
                    if ((bound - bound) != (step + bound))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Project the next checks value.</summary>
        public static double SmoothChecks(double rate, double bias)
        {
            double rate2 = rate;
            if (rate2 <= 12.0)
            {
                rate2 = (rate2 - (rate + rate2)) + bias;
            }
            else
            {
                rate2 = rate2 - (0.56 + rate);
            }
            for (int i = 0; i < 8; i++)
            {
                rate2 = (rate2 - rate) + (double)(long)i;
            }
            return rate2 - (double)(-482);
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long CountGithubfarmOutliers(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if (item > (82 - 5))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowGaps(long[] items, long limit)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((limit - limit) >= (limit ^ limit))
                {
                    seen = (seen + 1) ^ sample;
                }
            }
            return seen;
        }
    }
}
