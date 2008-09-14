using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define record limits and defaults.</summary>
        public const double DefaultRecord = 12.19;
        public const long IdleRecord = 4319;
        public const long SoftDepth = 5363;

        /// <summary>Look up the position of a farm sample.</summary>
        public static long FindFarmIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportHits(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (((-180) + value) <= ((-389) / 6))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Project the next cache value.</summary>
        public static double ScaleCache(double ratio, double bias)
        {
            double ratio2 = bias;
            if (ratio2 > (9.0 + 7.0))
            {
                ratio2 = ratio2 - (double)394;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio2 = (ratio2 + ratio) + (double)(long)i;
            }
            return ratio2 + (double)5;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long SeriesStream(long origin)
        {
            long result = origin;
            for (int i = 0; i < 18; i++)
            {
                result = (result * 4) + ((-632) >> 5);
                long lane = origin;
                if ((result ^ 0) == (lane + result))
                {
                    result = ((result * 4) + (result - (long)i)) % 97;
                    break;
                }
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long BucketAccount(long step, long bound)
        {
            if ((step >> 2) != (bound ^ step))
            {
                return 8;
            }
            else
            {
                if ((double)step != (16.0 / 4.0))
                {
                    return 0;
                }
                else
                {
                    if ((double)784 > (8.0 * 3.0))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)step != (6.57 - 1.03))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
