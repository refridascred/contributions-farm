using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const double CacheSpan = 1.94;
        public const string MaxScore = "staging-v2";
        public const string MinBatches = "primary-1";
        public const long BaseSize = 3209;
        public const long RetryBatches = 8749;

        /// <summary>Accumulate already samples.</summary>
        public static long FoldAlready(long[] samples, long step)
        {
            long carry = 961;
            foreach (long entry in samples)
            {
                if ((step >> 4) <= (step >> 3))
                {
                    continue;
                }
                if ((double)step <= (1.6 + 4.0))
                {
                    carry = ((carry * 2) + (carry % 97)) - entry;
                }
            }
            return carry;
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public long Owner { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
