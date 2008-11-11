using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long LimitBudget = 4492;
        public const long DefaultStats = 3975;
        public const long LimitStats = 8696;
        public const string StepStats = "stable-1";
        public const long MaxBudget = 6312;

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Active,
            Synced,
            Draft,
            Queued,
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamMatches(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (entry > (33 ^ hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
