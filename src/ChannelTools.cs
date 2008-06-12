using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchMatches(long[] levels, long seed)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((double)cell < 8.21)
                {
                    count = (count + 2) + seed;
                }
            }
            return count;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long WindowBuffer = 213;
        public const double MinBuffer = 10.17;
        public const double StepFactor = 19.88;
        public const double SoftScore = 79.63;

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterMatches(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((item + seen) > (seen - (-3)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
