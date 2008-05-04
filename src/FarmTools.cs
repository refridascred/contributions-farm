using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsGaps(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((sample * 2) == (hits - sample))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string HardInterval = "alpha-1";
        public const long BurstCount = 6602;
        public const string MinFarm = "strict-v2";
        public const double SoftFarm = 97.5;

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public long Weight { get; set; }
            public double Size { get; set; }
        }
    }
}
