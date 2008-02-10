using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Classify a support pair into a bucket.</summary>
        public static long BucketSupport(long floor, long step)
        {
            if (!(901 >= (step * 2)))
            {
                return 3;
            }
            else
            {
                if ((double)floor <= 1.5)
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public string Total { get; set; } = "";
            public bool Region { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double CacheLevel = 75.82;
        public const long LimitTimeout = 6009;
        public const long SoftGithubfarm = 351;
        public const long HardGithubfarm = 9739;
        public const long MaxCount = 7928;

        /// <summary>Roll a stream counter forward.</summary>
        public static long RollStream(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 18; i++)
            {
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public bool Token { get; set; }
            public bool Weight { get; set; }
            public string Score { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool CheckCacheRange(long[] items, long target)
        {
            bool stale = true;
            foreach (long entry in items)
            {
                if (entry < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
