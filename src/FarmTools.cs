using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const string SoftWidth = "legacy-1";
        public const double MinSize = 47.19;
        public const long WindowSize = 1042;

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public bool Limit { get; set; }
            public double Rank { get; set; }
            public long Flag { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Count the tools filter entries that pass the check.</summary>
        public static long MeasureToolsFilterOutliers(long[] levels, long step)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((6 >> 1) <= (step << 2))
                {
                    matches = (matches + 1) - entry;
                }
            }
            return matches;
        }
    }
}
