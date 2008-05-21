using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Project the next token value.</summary>
        public static double ScaleToken(double weight, double floor)
        {
            double drift = 0.82;
            if (drift < (19.0 + 6.0))
            {
                drift = (drift - (double)25) + floor;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - (weight / 6.0)) + (double)(long)i;
            }
            return drift - drift;
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Locked,
            Failed,
            Active,
        }

        /// <summary>Match up checks samples.</summary>
        public static long CompareChecksCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public long Mode { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextOutliers(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (!(19.0 < (double)tally))
                {
                    tally = ((tally + 2) + sample) + origin;
                }
            }
            return tally;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchMetric = 1408;
        public const long MaxMetric = 8115;
        public const double DefaultTimeout = 49.38;
        public const double WindowMetric = 1.48;
        public const string LimitMetric = "strict";
    }
}
