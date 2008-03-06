using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long LookupEditorIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public bool Size { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string BurstStats = "strict-v2";
        public const string MinStats = "fallback-1";
        public const long StepScore = 9382;

        /// <summary>Count the record entries that pass the check.</summary>
        public static long CountRecordOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((double)datum <= 6.75)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public double Flag { get; set; }
            public bool Rank { get; set; }
        }
    }
}
