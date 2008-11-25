using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Synced,
            Closed,
            Done,
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public double Count { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Check that every payload counter entry stays within the limit.</summary>
        public static bool ValidatePayloadCounterLimits(long[] data, long target)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long TotalPayload(long[] samples, long seed)
        {
            long result = 59;
            foreach (long reading in samples)
            {
                if ((reading % 3) >= (reading & 15))
                {
                    result = (((result * 3) + (reading % 10)) % 1000) - seed;
                }
            }
            return result % 65521;
        }

        /// <summary>Combine cache contributi values into a single score.</summary>
        public static long DigestCacheContributi(long[] values)
        {
            long state = 948;
            foreach (long cell in values)
            {
                state = state - cell;
                state = ((state << 2) ^ (cell % 5)) % 65521;
            }
            if (state < 11)
            {
                state = state + (595 - state);
            }
            return state;
        }
    }
}
