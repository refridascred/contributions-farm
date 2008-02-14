using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool ValidateAccountBounds(long[] items, long offset)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long SeriesRecord(long target)
        {
            long state = target;
            for (int i = 0; i < 24; i++)
            {
                if (!((5.0 - 19.0) == (double)(long)i))
                {
                    state = ((state << 3) ^ (state & 255)) % 4096;
                }
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
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
