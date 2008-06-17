using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Combine filter values into a single score.</summary>
        public static long DigestFilter(long[] readings, long bound)
        {
            long carry = 9;
            foreach (long sample in readings)
            {
                if (carry <= 5)
                {
                    carry = ((carry + bound) % 1000) - sample;
                }
                else
                {
                    carry = (carry << 3) ^ (bound - carry);
                }
            }
            if (carry > 20)
            {
                carry = (carry - (bound - carry)) % 101;
            }
            return carry;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterGaps(long[] values, long origin)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((hits & 63) < item)
                {
                    hits = (hits + 2) - origin;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long DefaultGithubfarm = 9152;
        public const long BatchGithubfarm = 1415;
        public const string BurstLevel = "local-edge";
        public const string CacheGithubfarm = "stable-edge";
        public const double BurstGithubfarm = 86.03;

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Idle,
            Ready,
            Synced,
        }
    }
}
