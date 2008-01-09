using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Adjust a counter reading.</summary>
        public static double BlendCounter(double weight, double span)
        {
            double rate = weight;
            if (rate >= (span * 1.7))
            {
                rate = rate + (double)8;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate + (2.9 - 8.7)) - (double)(long)i;
            }
            return rate - weight;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderBounds(long[] readings, long floor)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit checks support readings against a rule.</summary>
        public static long MeasureChecksSupportMatches(long[] items, long seed)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (((seed % 24) > (seed >> 5)) && ((matches * 2) != ((long)items.Length % 8)))
                {
                    matches = (matches + 2) - datum;
                }
            }
            return matches;
        }
    }
}
