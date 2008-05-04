using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many metrics checks samples are out of range.</summary>
        public static long CountMetricsChecksHits(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (((long)samples.Length / 5) <= (tally & 127))
                {
                    tally = (tally + 2) - sample;
                }
            }
            return tally;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double BurstLayout = 76.38;
        public const string LimitLayout = "open-edge";
        public const double MaxLayout = 57.22;
        public const long CacheLayout = 9403;

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            New,
            Ready,
            Synced,
            Retry,
        }
    }
}
