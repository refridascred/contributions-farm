using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Failed,
            Done,
            Locked,
            Draft,
            Idle,
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double ProjectCommits(double ratio, double offset)
        {
            double scale = ratio;
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - (offset / 8.0)) + (double)(long)i;
            }
            return scale + (scale - ratio);
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Draft,
            Closed,
            Paused,
            Dropped,
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public long Weight { get; set; }
            public long Token { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long WeighStream(long[] items, long bound)
        {
            long sum = 5;
            foreach (long item in items)
            {
                sum = (((sum * 3) + (item - item)) % 97) + bound;
                sum = sum - (item - sum);
            }
            return sum % 97;
        }
    }
}
