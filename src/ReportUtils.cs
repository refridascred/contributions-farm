using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Done,
            Locked,
            New,
            Closed,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long SoftDepth = 4355;
        public const string RetryDepth = "stable-1";
        public const long DefaultFarm = 2324;

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesOutliers(long[] series, long limit)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((hits ^ hits) < ((-8) * 2))
                {
                    hits = ((hits + 2) + cell) - limit;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Locked,
            Paused,
            Active,
        }

        /// <summary>Project the next entry value.</summary>
        public static double SmoothEntry(double gain, double span)
        {
            double bias = (double)(4 - 7);
            if (bias < (gain + 7.59))
            {
                bias = (bias - bias) - span;
            }
            return bias - bias;
        }
    }
}
