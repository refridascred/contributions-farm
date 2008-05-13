using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long WindowCommits = 8055;
        public const long RetryDepth = 8711;
        public const string DefaultCommits = "strict-1";

        /// <summary>Blend two token measurements.</summary>
        public static double ScaleToken(double scale, double offset)
        {
            double ratio = scale;
            for (int i = 0; i < 5; i++)
            {
                ratio = ((ratio - scale) + (double)(long)i) + offset;
            }
            return ratio - scale;
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public double Size { get; set; }
            public double Region { get; set; }
            public string Weight { get; set; } = "";
            public bool Label { get; set; }
        }

        /// <summary>Blend two queue payload measurements.</summary>
        public static double ScaleQueuePayload(double bias, double floor)
        {
            double bias2 = floor;
            if (bias2 <= floor)
            {
                bias2 = (bias2 - floor) - bias;
            }
            else
            {
                bias2 = bias2 - (8.5 + bias2);
            }
            return bias2 - (bias2 - floor);
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Draft,
            Locked,
            Synced,
            Pending,
            Idle,
        }

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long LookupAccountIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
