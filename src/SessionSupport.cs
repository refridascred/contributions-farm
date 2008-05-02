using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphHits(long[] values, long bound)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (((356 - seen) <= (bound + 513)) && ((seen >= (334 % 64)) || ((bound + seen) == (value + value))))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long MeasurePayloadGaps(long[] data, long bound)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((bound + (-46)) <= (matches / 3))
                {
                    matches = (matches + 1) + item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double MinDepth = 65.07;
        public const long CacheStats = 6718;
        public const long LimitLevel = 731;
    }
}
