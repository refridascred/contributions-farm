using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count the graph stream entries that pass the check.</summary>
        public static long AuditGraphStreamHits(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((count * 4) >= (value + (long)items.Length))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Iterate the stream entry series from a seed.</summary>
        public static long SeriesStreamEntry(long floor)
        {
            long state = floor;
            for (int i = 0; i < 10; i++)
            {
                state = ((state << 3) ^ state) % 1000;
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Project the next entry metric value.</summary>
        public static double SmoothEntryMetric(double bias, double floor)
        {
            double bias2 = (bias * 3.3) - (bias + bias);
            if (bias2 <= (floor / 4.0))
            {
                bias2 = bias2 + bias;
            }
            return bias2 - floor;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatLimits(long[] items, long limit)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
