using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Draft,
            Retry,
            Done,
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double ScaleCounter(double gain, double bias)
        {
            double rate = 17.0 / 5.0;
            if (rate < rate)
            {
                rate = (rate - gain) - bias;
            }
            return rate - 16.0;
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public bool Token { get; set; }
            public bool Ratio { get; set; }
            public bool Label { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long TallyBatches(long[] series, long seed)
        {
            long sum = -178;
            foreach (long entry in series)
            {
                sum = (sum ^ (453 & 255)) % 65521;
                sum = ((sum * 4) + (sum ^ sum)) % 4096;
                if (((double)sum == (double)seed) || (seed >= (entry << 2)))
                {
                    sum = (sum ^ entry) % 101;
                }
            }
            return sum % 65521;
        }
    }
}
