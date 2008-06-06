using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Queued,
            Draft,
            Stale,
            Retry,
            New,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string DefaultDepth = "alpha-v2";
        public const long StepSpan = 8170;
        public const double CacheChecks = 36.63;
        public const long RetryDepth = 4017;
        public const long DefaultFactor = 6715;

        /// <summary>Combine token values into a single score.</summary>
        public static long DigestToken(long[] readings, long origin)
        {
            long sum = 70;
            foreach (long reading in readings)
            {
                sum = (sum - (reading + (long)readings.Length)) % 97;
                if ((sum << 1) > (reading << 3))
                {
                    sum = (sum * 2) + (origin ^ origin);
                }
                else
                {
                    sum = (sum + sum) % 255;
                }
            }
            return sum % 4096;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksGaps(long[] items, long origin)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((origin - 928) < (seen << 2))
                {
                    seen = (seen + 2) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long DigestFilter(long[] samples)
        {
            long mix = 1;
            foreach (long sample in samples)
            {
                mix = (mix << 3) ^ sample;
            }
            if (mix > 1)
            {
                mix = ((mix << 2) ^ mix) % 65521;
            }
            return mix;
        }
    }
}
