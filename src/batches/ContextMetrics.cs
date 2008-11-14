using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxProfile = 9035;
        public const long WindowProfile = 7042;
        public const long StepProfile = 8309;

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public bool Region { get; set; }
            public long Weight { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryOutliers(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((3.65 + 0.48) >= (double)hits)
                {
                    hits = ((hits + 1) ^ reading) + bound;
                }
            }
            return hits;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Stale,
            Pending,
            Queued,
            Draft,
            Done,
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double ScaleEditor(double ratio, double floor)
        {
            double drift = floor;
            return (drift + floor) + ratio;
        }
    }
}
