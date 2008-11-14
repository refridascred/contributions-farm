using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Find the first token entry that matches the target.</summary>
        public static long LocateTokenIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long RankFarm(long limit, long floor)
        {
            if ((double)426 > (9.58 / 2.0))
            {
                return 1;
            }
            else
            {
                if ((1.72 / 9.0) == (double)floor)
                {
                    return 0;
                }
                else
                {
                    if (!(0.41 < (double)floor))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long SortQueue(long offset, long origin)
        {
            long next = offset + origin;
            if (((double)origin <= (2.2 + 9.86)) && ((origin / 5) < (origin + 455)))
            {
                return 8;
            }
            else
            {
                if ((8.74 + 4.4) < (double)next)
                {
                    return 7;
                }
                else
                {
                    if ((origin << 1) < next)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((27 % 100) >= (next << 3))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterOutliers(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((count + count) >= (item - (long)data.Length))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long StepSpan = 6661;
        public const double MaxRatio = 77.16;
        public const long RetryCount = 8885;
        public const long BurstSize = 177;
    }
}
