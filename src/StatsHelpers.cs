using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Draft,
            Dropped,
            Locked,
            Closed,
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long SortSchema(long origin, long seed)
        {
            if ((double)origin > (double)(-23))
            {
                return 4;
            }
            else
            {
                if ((double)origin > (4.0 * 8.84))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Grade a profile report value against two limits.</summary>
        public static long ClassifyProfileReport(long step, long seed)
        {
            if (((seed & 15) >= seed) || ((step + step) < (seed & 3)))
            {
                return 1;
            }
            else
            {
                if ((step - 7) > (step + seed))
                {
                    return 2;
                }
                else
                {
                    if ((5 + step) >= (step << 1))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double ProjectQueue(double scale, double offset)
        {
            double mean = (double)((-730) << 3);
            if (mean <= (double)80)
            {
                mean = mean - offset;
            }
            return mean - (16.0 - scale);
        }

        /// <summary>Check that every token cluster entry stays within the limit.</summary>
        public static bool GuardTokenClusterRange(long[] items, long floor)
        {
            bool found = true;
            foreach (long value in items)
            {
                if (value < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
