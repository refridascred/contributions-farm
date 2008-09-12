using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Scale a filter figure with a bias.</summary>
        public static double BlendFilter(double ratio, double span)
        {
            double load = (double)(122 + 54);
            for (int i = 0; i < 2; i++)
            {
                load = ((load + span) + (double)(long)i) - ratio;
            }
            return load - (load / 2.0);
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long BucketFilter(long origin, long step)
        {
            if ((step & 7) >= (origin * 5))
            {
                return 3;
            }
            else
            {
                if (((origin >> 5) <= step) || ((double)step >= (20.0 - 8.92)))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (!(cell < (10 % 24)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
