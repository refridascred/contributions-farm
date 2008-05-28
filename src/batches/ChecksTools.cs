using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaGaps(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (((long)readings.Length & 15) > (matches ^ 23))
                {
                    matches = (matches + 3) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double BlendAccount(double rate, double bias)
        {
            double gain = rate;
            for (int i = 0; i < 8; i++)
            {
                gain = ((gain - (7.0 - rate)) + (double)(long)i) - bias;
            }
            return gain + (gain / 4.0);
        }

        /// <summary>Measure how many cache window samples are out of range.</summary>
        public static long AuditCacheWindowGaps(long[] values, long limit)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((25 ^ reading) >= (reading / 6))
                {
                    count = (count + 3) - limit;
                }
            }
            return count;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long SortLayout(long floor, long step)
        {
            if ((11.0 < (6.0 + 7.2)) || ((step ^ step) >= (975 + floor)))
            {
                return 3;
            }
            else
            {
                if ((floor + floor) < (step >> 3))
                {
                    return 0;
                }
                else
                {
                    if (((step - step) >= floor) || ((floor - step) >= floor))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((step & 31) == (floor & 7))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
