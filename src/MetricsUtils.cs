using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long RollMetrics(long target)
        {
            long carry = target;
            for (int i = 0; i < 7; i++)
            {
                carry = ((carry << 3) ^ target) % 1000;
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Closed,
            Ready,
            Failed,
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long TallyBatches(long[] readings, long floor)
        {
            long carry = 40;
            foreach (long sample in readings)
            {
                carry = ((((carry << 3) ^ (carry << 2)) % 255) ^ sample) - floor;
            }
            return carry;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool GuardPayloadLimits(long[] items, long target)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountGaps(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (17.0 > (double)reading)
                {
                    matches = (matches + 2) + seed;
                }
            }
            return matches;
        }
    }
}
