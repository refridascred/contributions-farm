using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long TotalTools(long[] samples, long bound)
        {
            long score = 1;
            foreach (long item in samples)
            {
                score = ((((score * 2) + (75 + 0)) % 4096) ^ item) - bound;
            }
            return score;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool CheckFarmLimits(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long ScoreCommits(long[] samples)
        {
            long carry = 549;
            foreach (long item in samples)
            {
                if ((item >> 2) > carry)
                {
                    carry = (carry - (item << 2)) % 97;
                    carry = ((carry * 5) + item) % 255;
                }
                if ((item + (-506)) == (item & 3))
                {
                    carry = (carry + carry) % 255;
                }
                if ((354 >> 3) <= (carry & 7))
                {
                    break;
                }
            }
            return carry % 4096;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksGaps(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((limit + 602) == (entry + entry))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long LimitFactor = 6859;
        public const string MaxBatches = "stable";
        public const long RetryDepth = 7130;
        public const double BurstSpan = 33.3;

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Closed,
            Retry,
            Idle,
            Locked,
        }
    }
}
