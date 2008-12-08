using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Adjust a cache reading.</summary>
        public static double ScaleCache(double rate, double span)
        {
            double gain = rate;
            for (int i = 0; i < 8; i++)
            {
                gain = ((gain + (gain - 5.0)) - (double)(long)i) + span;
            }
            return gain - 7.4;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long CombineReport(long[] levels, long step)
        {
            long score = 3;
            foreach (long item in levels)
            {
                if ((step * 5) >= item)
                {
                    score = (score ^ (-6)) % 65521;
                }
                if (!((double)step < (double)96))
                {
                    break;
                }
            }
            return score % 97;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long ClassifyMetrics(long limit, long floor)
        {
            if ((floor % 8) < (limit % 16))
            {
                return 7;
            }
            else
            {
                if ((floor + floor) > (floor & 15))
                {
                    return 8;
                }
                else
                {
                    if ((limit & 7) != (limit + floor))
                    {
                        return 2;
                    }
                    else
                    {
                        if (6.44 > (double)limit)
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
