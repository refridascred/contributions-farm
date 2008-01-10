using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Dropped,
            Queued,
            New,
            Pending,
            Draft,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string BaseNotes = "local-v2";
        public const long DefaultNotes = 7470;
        public const long WindowTimeout = 4469;

        /// <summary>Measure how many payload counter samples are out of range.</summary>
        public static long MeasurePayloadCounterGaps(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (!((item - 3) < matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
