using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long IdleGithubfarm = 5818;
        public const double HardScore = 35.66;
        public const double MinTimeout = 85.0;
        public const double StepGithubfarm = 86.2;
        public const double DefaultSize = 2.79;

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public long Ratio { get; set; }
            public long Count { get; set; }
        }

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
