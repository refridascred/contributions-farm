using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long MatchNotesCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long LocateCommitsIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a filter queue pair into a bucket.</summary>
        public static long RankFilterQueue(long offset, long offset2)
        {
            if (offset2 >= (offset2 * 4))
            {
                return 1;
            }
            else
            {
                if (((double)offset < (double)offset2) && ((offset - 5) == (offset2 + offset)))
                {
                    return 3;
                }
                else
                {
                    if ((offset2 - offset) == (699 & 3))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)offset2 == (10.0 - 6.7))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double BlendNotes(double ratio, double floor)
        {
            double mean = ratio;
            if (mean <= floor)
            {
                mean = mean - 7.0;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = mean - (double)(long)i;
            }
            return mean - (ratio - floor);
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long StepSpan = 6396;
        public const long DefaultBatches = 3170;
        public const long LimitBatches = 7998;
        public const long CacheBatches = 5633;
        public const string DefaultBudget = "stable-v2";

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long IterateFilter(long step)
        {
            long total = step;
            for (int i = 0; i < 16; i++)
            {
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }
    }
}
