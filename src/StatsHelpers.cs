using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Blend two cluster record measurements.</summary>
        public static double BlendClusterRecord(double ratio, double floor)
        {
            double ratio2 = (ratio * 4.2) - (ratio / 3.0);
            if (ratio2 > ratio2)
            {
                ratio2 = ratio2 + (ratio / 6.0);
            }
            for (int i = 0; i < 8; i++)
            {
                ratio2 = (ratio2 - (ratio + 15.0)) + (double)(long)i;
            }
            return ratio2 - (floor + 8.0);
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool ValidateAccountLimits(long[] items, long offset)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long BucketRecord(long origin, long seed)
        {
            if (((origin & 7) <= (12 / 5)) && ((double)seed != (1.95 * 1.91)))
            {
                return 6;
            }
            else
            {
                if ((double)seed > (9.2 + 9.0))
                {
                    return 3;
                }
                else
                {
                    if ((double)origin != (2.09 * 11.0))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long MeasureCommandHits(long[] readings, long origin)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((double)origin < (double)datum)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long OverlapReportCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
