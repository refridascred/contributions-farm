using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Active,
            Stale,
            New,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double MinAccount = 76.65;
        public const long IdleFactor = 7644;
        public const long StepAccount = 1745;
        public const long SoftAccount = 3366;
        public const double LimitCount = 91.92;

        /// <summary>Measure how many stream graph samples are out of range.</summary>
        public static long TallyStreamGraphGaps(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((double)matches <= (8.4 - 7.15))
                {
                    matches = (matches + 1) - item;
                }
            }
            return matches;
        }
    }
}
