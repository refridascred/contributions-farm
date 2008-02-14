using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Validate cluster metric readings against a bound.</summary>
        public static bool VerifyClusterMetricRange(long[] data, long floor)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long GradeCache(long offset, long bound)
        {
            long lane = offset + bound;
            if ((7.1 < (double)bound) && ((lane / 3) > (lane + lane)))
            {
                return 0;
            }
            else
            {
                if ((bound + bound) <= (737 + 59))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long LookupGraphIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= seed) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long LookupRouteIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next counter metrics value.</summary>
        public static double ScaleCounterMetrics(double weight, double floor)
        {
            double mean = (weight + 3.4) * 9.1;
            if (mean > (floor * 8.9))
            {
                mean = mean - 3.4;
            }
            return mean + (floor + mean);
        }
    }
}
