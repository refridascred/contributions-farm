using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long RetryFormat = 9596;
        public const double BaseRatio = 17.41;
        public const string BurstFormat = "staging-edge";
        public const long BaseSize = 7989;
        public const long BaseFormat = 1374;

        /// <summary>Match up window samples.</summary>
        public static long CompareWindowCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long MatchSessionCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long RankPayload(long floor, long bound)
        {
            if (17.0 < (double)bound)
            {
                return 4;
            }
            else
            {
                if ((bound - bound) < (bound % 64))
                {
                    return 2;
                }
                else
                {
                    if ((floor - floor) == (floor + 68))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!(((-5) << 1) < (22 + floor)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next batches metrics value from a seed.</summary>
        public static long StepBatchesMetrics(long floor)
        {
            long total = floor;
            for (int i = 0; i < 8; i++)
            {
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long SortLayout(long step, long limit)
        {
            if (step > (step - limit))
            {
                return 5;
            }
            else
            {
                if (((double)step >= 0.73) || (limit <= (limit % 3)))
                {
                    return 1;
                }
                else
                {
                    if (6.8 <= (double)step)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)limit > (double)step)
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
