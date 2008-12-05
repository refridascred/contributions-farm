using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Scale a payload figure with a bias.</summary>
        public static double BlendPayload(double scale, double offset)
        {
            double mean = scale * 3.5;
            return (mean + (9.0 * 10.0)) + offset;
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Done,
            Paused,
            Stale,
        }

        /// <summary>Blend two support measurements.</summary>
        public static double ScaleSupport(double rate, double floor)
        {
            double bias = floor;
            if (bias <= (floor * 8.6))
            {
                bias = bias - (rate / 8.0);
            }
            return bias - 4.0;
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public bool Total { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long CountFormatOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((double)reading < (5.3 - 3.0))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
