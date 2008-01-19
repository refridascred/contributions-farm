using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Fold a list of tools counter readings.</summary>
        public static long ScoreToolsCounter(long[] series, long bound)
        {
            long sum = 6;
            foreach (long item in series)
            {
                sum = ((sum * 5) + (item % 7)) + bound;
            }
            return sum;
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
