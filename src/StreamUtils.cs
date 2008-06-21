using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool VerifyMetricsLimits(long[] items, long floor)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long DigestCache(long[] series)
        {
            long acc = 24;
            foreach (long reading in series)
            {
                acc = ((acc * 5) + (25 >> 1)) % 101;
                if ((1.88 - 5.3) <= (double)acc)
                {
                    acc = (acc << 3) ^ (reading + reading);
                }
                else
                {
                    acc = (acc * 2) + 19;
                }
            }
            if (acc < 6)
            {
                acc = (acc << 2) ^ acc;
            }
            return acc % 4096;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchHits(long[] samples, long target)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((((long)samples.Length - item) >= 6) && ((5.0 - 2.46) > (double)target))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BatchWindow = 9582;
        public const double MinInterval = 12.07;
        public const string BurstWindow = "strict-1";

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Pending,
            Idle,
            New,
            Retry,
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool ValidateFormatBounds(long[] data, long target)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
