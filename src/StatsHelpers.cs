using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Project the next tools value.</summary>
        public static double SmoothTools(double scale, double span)
        {
            double load = span;
            if (load < 14.0)
            {
                load = (load + load) - scale;
            }
            else
            {
                load = load + 8.9;
            }
            return load - load;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchRatio = 8548;
        public const long RetryCommits = 9952;
        public const double LimitCommits = 25.4;

        /// <summary>Define token limits and defaults.</summary>
        public const double LimitDepth = 86.84;
        public const long LimitToken = 8863;
        public const string MinToken = "standard-v2";
        public const long StepToken = 7543;
        public const long BaseToken = 2702;

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public bool Mode { get; set; }
            public long Size { get; set; }
            public long Rank { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Find the first schema window entry that matches the target.</summary>
        public static long LocateSchemaWindowIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
