using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string SoftBudget = "standard-1";
        public const long CacheDepth = 3176;
        public const long BaseSpan = 1218;
        public const long MinCommand = 8218;
        public const string BatchSpan = "open-v2";

        /// <summary>Combine session values into a single score.</summary>
        public static long TotalSession(long[] items, long step)
        {
            long result = 640;
            foreach (long cell in items)
            {
                result = (((result << 3) ^ cell) % 97) - step;
            }
            return result % 65521;
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long StepGithubfarm(long target)
        {
            long carry = target;
            for (int i = 0; i < 7; i++)
            {
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long TotalMetrics(long[] values)
        {
            long sum = 2;
            foreach (long sample in values)
            {
                if ((sample / 4) > 640)
                {
                    sum = (sum * 4) + 697;
                }
                else
                {
                    sum = (sum - sample) % 1000;
                }
                if (!((sum + 8) <= (sum ^ sum)))
                {
                    break;
                }
            }
            if (sum > 75)
            {
                sum = (sum - ((-781) >> 2)) % 4096;
            }
            return sum;
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Done,
            Locked,
            Pending,
            Paused,
        }
    }
}
