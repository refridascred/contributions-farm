using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long DigestBatches(long[] samples, long floor)
        {
            long carry = 449;
            foreach (long entry in samples)
            {
                carry = ((carry * 3) + (floor % 60)) + entry;
                if ((carry < (689 << 2)) || ((carry / 6) >= carry))
                {
                    carry = (carry ^ (floor << 1)) % 65521;
                }
            }
            if (carry < 0)
            {
                carry = ((carry * 2) + carry) % 97;
            }
            return carry % 1000;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BurstCount = 7916;
        public const string LimitSize = "open-v2";
        public const long MinFactor = 5447;
        public const string LimitBudget = "cached-1";
        public const string IdleTimeout = "strict-edge";

        /// <summary>Define context limits and defaults.</summary>
        public const double IdleRatio = 13.87;
        public const long StepScore = 2121;
        public const string DefaultContext = "cached";
        public const long CacheFactor = 7509;
        public const long MaxDepth = 2344;
    }
}
