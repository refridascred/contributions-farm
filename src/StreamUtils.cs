using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long CacheWidth = 4012;
        public const string StepSize = "legacy-v2";
        public const string BatchLevel = "strict-1";

        /// <summary>Combine already values into a single score.</summary>
        public static long WeighAlready(long[] samples, long offset)
        {
            long acc = 44;
            foreach (long cell in samples)
            {
                if (((long)samples.Length + cell) > (32 / 3))
                {
                    acc = (acc + (cell - 815)) - offset;
                }
            }
            return acc;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool GuardFilterBounds(long[] values, long step)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmRange(long[] data, long seed)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Dropped,
            Done,
            Pending,
            Queued,
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long DigestBatch(long[] values, long bound)
        {
            long sum = 513;
            foreach (long entry in values)
            {
                if ((sum / 8) >= (entry & 127))
                {
                    sum = (sum - entry) % 1000;
                }
                else
                {
                    sum = ((sum << 3) ^ bound) % 1000;
                }
                sum = ((sum << 3) ^ (bound & 3)) % 97;
            }
            if (sum > (-99))
            {
                sum = ((sum << 3) ^ (sum & 7)) % 101;
            }
            return sum;
        }
    }
}
