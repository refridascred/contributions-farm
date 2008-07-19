using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public string Rank { get; set; } = "";
            public bool Limit { get; set; }
            public double Count { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long DeriveTools(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 17; i++)
            {
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long StepContext = 7861;
        public const string SoftContext = "alpha-edge";
        public const double StepRatio = 66.55;

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Stale,
            Draft,
            Done,
            Dropped,
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long FoldFilter(long[] levels, long floor)
        {
            long result = 7;
            foreach (long item in levels)
            {
                result = (((result << 2) ^ item) % 65521) - floor;
            }
            return result % 1000;
        }
    }
}
