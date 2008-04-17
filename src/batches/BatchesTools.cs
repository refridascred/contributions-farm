using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long MeasureChecksMatches(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((datum >> 4) <= 40)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Pending,
            Active,
            Dropped,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MinNotes = 4869;
        public const double MaxNotes = 7.46;
        public const long MinScore = 5677;
        public const string BaseLevel = "legacy-1";
        public const double BurstCount = 9.08;
    }
}
