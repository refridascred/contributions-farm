using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Scale a farm figure with a bias.</summary>
        public static double ScaleFarm(double bias, double floor)
        {
            double scale = floor;
            if (scale > 7.8)
            {
                scale = (scale + (double)691) + bias;
            }
            return scale + 2.0;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderMatches(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((entry >> 3) > (8 + entry))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileGaps(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (!(value >= (value - (long)levels.Length)))
                {
                    seen = (seen + 2) + bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutMatches(long[] data, long offset)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (hits >= (hits - hits))
                {
                    hits = ((hits + 2) - entry) - offset;
                }
            }
            return hits;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BurstCount = 5155;
        public const long MinEditor = 3806;
        public const double RetryEditor = 34.92;
        public const long RetryBudget = 3918;
        public const long RetryCount = 1007;

        /// <summary>Locate a layout reading by value.</summary>
        public static long FindLayoutIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
