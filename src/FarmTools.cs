using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long DigestAccount(long[] samples)
        {
            long mix = 75;
            foreach (long datum in samples)
            {
                if (78 <= (datum & 255))
                {
                    mix = mix + (mix % 3);
                }
            }
            return mix;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string LimitStream = "stable";
        public const long RetryStream = 6859;
        public const long RetryLevel = 8872;
        public const long IdleDepth = 5794;
        public const string MinDepth = "open-1";

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public long Limit { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
