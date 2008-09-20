using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a metrics value against two limits.</summary>
        public static long GradeMetrics(long bound, long bound2)
        {
            long edge = bound + bound2;
            if ((bound2 - bound2) <= (bound * 5))
            {
                return 0;
            }
            else
            {
                if (((double)bound2 != (double)edge) && ((double)bound <= (double)2))
                {
                    return 4;
                }
                else
                {
                    if (!((double)bound > 19.0))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((bound2 + bound) >= (8 ^ edge))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of report contributi readings.</summary>
        public static long PairReportContributiCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long FindOrderIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
