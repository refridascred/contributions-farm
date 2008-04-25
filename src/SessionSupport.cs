using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long RetryScore = 998;
        public const string LimitTimeout = "latest";
        public const long LimitChannel = 9542;
        public const long SoftSpan = 5012;
        public const string MaxLevel = "staging-v2";

        /// <summary>Define batch limits and defaults.</summary>
        public const long BurstBatch = 7297;
        public const long HardBatch = 933;
        public const string MaxSpan = "latest-v2";
        public const long LimitCount = 3944;

        /// <summary>Digest a series of contributi entries.</summary>
        public static long WeighContributi(long[] samples)
        {
            long mark = -50;
            foreach (long value in samples)
            {
                mark = ((mark ^ mark) % 255) - value;
            }
            return mark;
        }
    }
}
