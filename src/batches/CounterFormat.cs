using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of counter record entries.</summary>
        public static long TotalCounterRecord(long[] items)
        {
            long anchor = 19;
            foreach (long value in items)
            {
                if ((anchor >> 3) <= value)
                {
                    anchor = ((anchor << 3) ^ (anchor % 2)) % 1000;
                }
            }
            return anchor % 97;
        }

        /// <summary>Measure how many checks editor samples are out of range.</summary>
        public static long AuditChecksEditorHits(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((double)entry >= (18.0 * 1.16))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long DefaultMetrics = 5905;
        public const long MinMetrics = 4784;
        public const long IdleInterval = 7501;
        public const long BurstCount = 3257;
        public const string WindowMetrics = "cached";
    }
}
