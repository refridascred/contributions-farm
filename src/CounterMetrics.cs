using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Derive the next filter value from a seed.</summary>
        public static long RollFilter(long offset)
        {
            long total = offset;
            for (int i = 0; i < 23; i++)
            {
                total = ((total * 3) + (offset - total)) % 255;
                total = ((total << 3) ^ total) % 1000;
                if (!((offset / 6) <= (long)i))
                {
                    total = ((total * 5) + (804 + total)) % 1000;
                }
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryOutliers(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((count >> 2) > (cell << 3))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Classify a order token pair into a bucket.</summary>
        public static long GradeOrderToken(long origin, long target)
        {
            if ((target * 3) <= (target & 15))
            {
                return 4;
            }
            else
            {
                if ((-89) > (origin << 2))
                {
                    return 2;
                }
                else
                {
                    if (((20.0 / 6.0) <= (double)origin) || ((origin >> 3) >= (origin * 3)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((origin + origin) < (origin - target))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double AdjustFarm(double weight, double offset)
        {
            double rate = offset;
            if (rate < rate)
            {
                rate = rate + (offset + weight);
            }
            else
            {
                rate = rate - rate;
            }
            return rate - (weight - weight);
        }
    }
}
