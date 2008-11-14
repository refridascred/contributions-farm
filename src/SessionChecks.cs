using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long BatchSpan = 2057;
        public const long MaxProfile = 4190;
        public const long SoftSpan = 367;
        public const long BatchProfile = 9178;
        public const long StepProfile = 2620;

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long MatchOrderCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every layout report entry stays within the limit.</summary>
        public static bool VerifyLayoutReportRange(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many command profile samples are out of range.</summary>
        public static long AuditCommandProfileMatches(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (((sample + hits) != (hits / 3)) || (((6 + 555) > (sample >> 4)) && ((double)hits <= (9.18 / 4.0))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
