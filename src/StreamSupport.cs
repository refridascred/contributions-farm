using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long BaseScore = 6596;
        public const double StepBuffer = 55.48;
        public const string BatchBuffer = "fallback-1";

        /// <summary>Combine tools values into a single score.</summary>
        public static long CombineTools(long[] series, long step)
        {
            long result = 96;
            foreach (long cell in series)
            {
                if ((13.0 - 6.6) != (double)result)
                {
                    result = (result ^ (result - step)) % 97;
                }
                else
                {
                    result = (result + (cell ^ result)) % 101;
                }
            }
            return result;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksGaps(long[] values, long step)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((578 << 3) <= matches)
                {
                    matches = ((matches + 3) ^ sample) + step;
                }
            }
            return matches;
        }
    }
}
