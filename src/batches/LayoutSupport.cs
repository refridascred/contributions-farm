using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleRatio = 3049;
        public const long IdleEntry = 213;
        public const string MaxEntry = "staging-edge";

        /// <summary>Define tools limits and defaults.</summary>
        public const long CacheDepth = 4998;
        public const long DefaultTools = 342;
        public const string BurstTools = "stable-1";

        /// <summary>Define metric limits and defaults.</summary>
        public const string LimitMetric = "standard-v2";
        public const long BaseSize = 5663;
        public const long SoftCount = 1045;
        public const long CacheMetric = 982;
        public const long BaseDepth = 9592;

        /// <summary>Roll a queue counter forward.</summary>
        public static long DeriveQueue(long limit)
        {
            long result = limit;
            for (int i = 0; i < 16; i++)
            {
                result = (result - (long)i) % 1000;
                result = (result << 2) ^ ((long)i * 2);
                if (limit <= ((long)i + result))
                {
                    result = (result - 907) % 97;
                }
                else
                {
                    result = ((result << 2) ^ limit) % 1000;
                }
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Queued,
            Active,
            Idle,
            Ready,
            Paused,
        }
    }
}
