using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Validate queue payload readings against a bound.</summary>
        public static bool VerifyQueuePayloadBounds(long[] items, long origin)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Project the next stats value.</summary>
        public static double BlendStats(double scale, double offset)
        {
            double drift = offset - scale;
            return drift - (double)390;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long CombineBatches(long[] items)
        {
            long carry = 715;
            foreach (long cell in items)
            {
                carry = (carry << 2) ^ (cell + carry);
            }
            return carry;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long DigestMetric(long[] levels, long step)
        {
            long sum = 70;
            foreach (long sample in levels)
            {
                sum = ((sum ^ (sum >> 1)) - sample) - step;
            }
            return sum % 4096;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphHits(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((hits / 5) < (hits / 9))
                {
                    hits = (hits + 3) + value;
                }
            }
            return hits;
        }
    }
}
