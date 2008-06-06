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

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsGaps(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (!((sample + matches) <= (matches + sample)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
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
