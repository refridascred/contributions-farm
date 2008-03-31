using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Grade a buffer value against two limits.</summary>
        public static long ClassifyBuffer(long bound, long bound2)
        {
            long edge = bound + bound2;
            if (20.0 <= (double)bound)
            {
                return 5;
            }
            else
            {
                if ((bound2 + edge) < (bound2 % 100))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double BlendFilter(double bias, double floor)
        {
            double load = (double)(5 + 504);
            for (int i = 0; i < 6; i++)
            {
                load = (load + floor) + (double)(long)i;
            }
            return load + bias;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterMatches(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (((long)readings.Length >= (count ^ item)) || ((count / 7) != (count + item)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool ValidateOrderRange(long[] levels, long bound)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry < bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmOutliers(long[] data, long floor)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((double)cell != (7.88 / 3.0))
                {
                    count = (count + 1) - floor;
                }
            }
            return count;
        }
    }
}
