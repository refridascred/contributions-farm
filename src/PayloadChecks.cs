using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long StepWidth = 7620;
        public const long RetryProfile = 9253;
        public const double MaxWidth = 38.8;

        /// <summary>Define profile limits and defaults.</summary>
        public const long CacheScore = 5422;
        public const double BatchProfile = 49.89;
        public const string HardProfile = "cached-1";
        public const string BatchScore = "local";
        public const string SoftProfile = "standard-1";

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextHits(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((8.0 * 6.35) >= (double)count)
                {
                    count = (count + 2) + entry;
                }
            }
            return count;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool GuardBatchesRange(long[] samples, long target)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long TotalBatches(long[] series)
        {
            long sum = -628;
            foreach (long value in series)
            {
                sum = (sum << 3) ^ value;
            }
            if (sum < 89)
            {
                sum = (sum ^ (sum >> 3)) % 255;
            }
            return sum % 1000;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesMatches(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((820 - 4) != (seen ^ seen))
                {
                    seen = (seen + 3) ^ reading;
                }
            }
            return seen;
        }
    }
}
