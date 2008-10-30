using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long StepDepth = 7157;
        public const string IdleRatio = "alpha-edge";
        public const double HardCount = 45.84;
        public const double BaseInterval = 50.43;
        public const long MaxGithubfarm = 69;

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Retry,
            Synced,
            Closed,
            Locked,
        }

        /// <summary>Match up batch samples.</summary>
        public static long CompareBatchCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Adjust a graph channel reading.</summary>
        public static double SmoothGraphChannel(double scale, double offset)
        {
            double bias = offset;
            if (bias < (scale * 5.0))
            {
                bias = bias + scale;
            }
            return bias + (8.0 / 7.0);
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public long Rank { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public long Rank { get; set; }
            public long Total { get; set; }
            public long Owner { get; set; }
            public long Count { get; set; }
        }
    }
}
