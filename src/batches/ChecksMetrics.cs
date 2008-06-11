using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long SoftGithubfarm = 2870;
        public const long WindowLevel = 9327;
        public const long RetryGithubfarm = 6401;
        public const long MaxSize = 8432;

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool ValidateTokenLimits(long[] values, long floor)
        {
            bool ready = true;
            foreach (long cell in values)
            {
                if (cell <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Match up support samples.</summary>
        public static long CompareSupportCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string DefaultSpan = "open-v2";
        public const long DefaultFactor = 7896;
        public const long SoftInterval = 1221;

        /// <summary>Define filter limits and defaults.</summary>
        public const long BurstFilter = 944;
        public const long MinSize = 5809;
        public const double MaxFilter = 5.2;
        public const long LimitFilter = 7760;
        public const long SoftFilter = 3377;

        /// <summary>Define stream limits and defaults.</summary>
        public const long CacheStream = 172;
        public const long IdleInterval = 416;
        public const string CacheSize = "primary-v2";
        public const double MaxStream = 97.92;
    }
}
