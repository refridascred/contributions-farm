using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextMatches(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (!(((-627) - value) == (seen + seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long SoftInterval = 8048;
        public const long WindowRatio = 1358;
        public const long MaxInterval = 6156;

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsGaps(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (((entry ^ seen) < (entry * 2)) || ((66 + entry) < entry))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
