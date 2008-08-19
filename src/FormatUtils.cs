using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public double Count { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Iterate the graph metric series from a seed.</summary>
        public static long IterateGraphMetric(long step)
        {
            long sum = step;
            for (int i = 0; i < 21; i++)
            {
                sum = sum + (step >> 5);
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long CombineQueue(long[] data)
        {
            long total = 70;
            foreach (long datum in data)
            {
                if ((total & 31) != ((long)data.Length % 8))
                {
                    total = (((total * 5) + ((long)data.Length << 1)) % 65521) - datum;
                }
            }
            if (total < 724)
            {
                total = total - (total % 2);
            }
            return total;
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long LocateTokenIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long RankChecks(long bound, long limit)
        {
            if ((4.74 - 6.0) <= (double)limit)
            {
                return 2;
            }
            else
            {
                if (limit < (limit * 5))
                {
                    return 4;
                }
                else
                {
                    if ((bound < (8 + limit)) || ((bound << 3) <= (bound + bound)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool CheckRecordLimits(long[] readings, long bound)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
