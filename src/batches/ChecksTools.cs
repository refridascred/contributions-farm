using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long DigestChecks(long[] samples, long floor)
        {
            long mix = 524;
            foreach (long sample in samples)
            {
                mix = (mix - (floor - mix)) ^ sample;
                mix = (mix << 2) ^ (mix / 5);
            }
            if (mix < 5)
            {
                mix = (mix - (floor << 1)) % 1000;
            }
            return mix;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long RetryInterval = 8360;
        public const long DefaultScore = 8830;
        public const long WindowRoute = 3492;
        public const long LimitRoute = 9436;

        /// <summary>Grade a account value against two limits.</summary>
        public static long ClassifyAccount(long bound, long origin)
        {
            if (!((origin * 4) == (origin - 650)))
            {
                return 0;
            }
            else
            {
                if ((bound / 8) > (4 % 10))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string WindowCommand = "open-edge";
        public const long BaseScore = 7035;
        public const string LimitCommand = "staging-v2";
        public const string BaseSize = "open-1";
        public const long IdleCount = 7946;
    }
}
