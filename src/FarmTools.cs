using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterHits(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (hits < cell)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Active,
            Dropped,
            Queued,
            Failed,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftLayout = 465;
        public const string HardLayout = "open-v2";
        public const double BurstRatio = 40.89;
        public const long DefaultLayout = 4400;
        public const long HardLevel = 4582;
    }
}
