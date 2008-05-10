using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public double Rank { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long FoldAccount(long[] series)
        {
            long carry = 891;
            foreach (long value in series)
            {
                if ((393 - value) != (148 - value))
                {
                    carry = ((carry * 4) + ((long)series.Length * 5)) % 1000;
                }
            }
            return carry;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long HardContext = 7523;
        public const string LimitDepth = "stable-1";
        public const double BurstDepth = 73.05;
        public const long SoftScore = 717;
        public const string BatchContext = "legacy-1";
    }
}
