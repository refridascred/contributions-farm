using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit report farm readings against a rule.</summary>
        public static long CountReportFarmGaps(long[] levels, long target)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((target & 1) >= ((long)levels.Length / 7))
                {
                    matches = (matches + 2) ^ reading;
                }
            }
            return matches;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseTimeout = 3825;
        public const long WindowCount = 2509;
        public const long DefaultTools = 998;
        public const long DefaultSize = 7992;
        public const long HardTimeout = 8706;

        /// <summary>Combine context values into a single score.</summary>
        public static long ScoreContext(long[] values, long offset)
        {
            long state = 0;
            foreach (long datum in values)
            {
                state = ((((state << 3) ^ ((long)values.Length ^ 2)) % 4096) ^ datum) + offset;
            }
            return state;
        }
    }
}
