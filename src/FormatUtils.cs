using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long AuditWindowHits(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((seen + seen) != (seen % 64))
                {
                    seen = (seen + 1) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BatchReport = 6354;
        public const long StepReport = 1891;
        public const double LimitBudget = 65.62;
        public const long LimitReport = 3611;
        public const long CacheFactor = 5044;

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteMatches(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (!(((seed - hits) > seed) || ((double)hits <= (double)553)))
                {
                    hits = (hits + 1) + item;
                }
            }
            return hits;
        }

        /// <summary>Blend two metrics route measurements.</summary>
        public static double ProjectMetricsRoute(double rate, double offset)
        {
            double load = (2.0 - rate) / 2.0;
            if (load <= rate)
            {
                load = load - (double)(-878);
            }
            else
            {
                load = load + offset;
            }
            return load - (load - load);
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long OverlapWindowCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool GuardFilterLimits(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
