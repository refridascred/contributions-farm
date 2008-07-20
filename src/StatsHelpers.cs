using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long WeighCommits(long[] data, long offset)
        {
            long anchor = 16;
            foreach (long entry in data)
            {
                if (9.04 > (double)offset)
                {
                    anchor = (anchor - (offset + entry)) % 4096;
                }
            }
            if (anchor < (-532))
            {
                anchor = (anchor << 2) ^ (7 << 2);
            }
            return anchor;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long WindowScore = 9463;
        public const long MinMetric = 7808;
        public const long SoftMetric = 8825;

        /// <summary>Define batch limits and defaults.</summary>
        public const double LimitBatch = 62.65;
        public const long WindowBatch = 7129;
        public const double HardSpan = 12.3;

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double SmoothPayload(double rate, double span)
        {
            double bias = span;
            if (bias > 5.65)
            {
                bias = bias + bias;
            }
            return bias + (rate + 6.83);
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Failed,
            Idle,
            Synced,
        }
    }
}
