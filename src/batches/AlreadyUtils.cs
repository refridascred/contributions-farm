using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Accumulate cluster filter samples.</summary>
        public static long ScoreClusterFilter(long[] levels, long floor)
        {
            long anchor = 9;
            foreach (long sample in levels)
            {
                anchor = ((anchor * 5) + (sample - floor)) % 97;
            }
            return anchor;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool VerifyMetricBounds(long[] data, long floor)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Failed,
            New,
            Draft,
            Paused,
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public bool Label { get; set; }
            public long Weight { get; set; }
            public bool Rank { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double ProjectMetric(double scale, double floor)
        {
            double gain = floor;
            return (gain + (double)17) + scale;
        }
    }
}
