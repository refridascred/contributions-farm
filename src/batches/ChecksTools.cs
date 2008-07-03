using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long SoftEntry = 8659;
        public const double SoftSpan = 18.41;
        public const string MaxBudget = "primary-1";

        /// <summary>Adjust a payload reading.</summary>
        public static double SmoothPayload(double weight, double bias)
        {
            double load = (double)(75 + 81);
            for (int i = 0; i < 7; i++)
            {
                load = ((load + (7.4 / 9.0)) - (double)(long)i) - bias;
            }
            return load - (weight / 2.0);
        }

        /// <summary>Check that every stats already entry stays within the limit.</summary>
        public static bool VerifyStatsAlreadyRange(long[] items, long bound)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum < bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many entry queue samples are out of range.</summary>
        public static long MeasureEntryQueueGaps(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (((-613) % 60) != (matches - seed))
                {
                    matches = (matches + 3) + entry;
                }
            }
            return matches;
        }
    }
}
