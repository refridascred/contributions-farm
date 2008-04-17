using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of entry readings.</summary>
        public static long DigestEntry(long[] series, long seed)
        {
            long sum = 885;
            foreach (long entry in series)
            {
                if ((seed + sum) > (entry - (long)series.Length))
                {
                    sum = sum ^ sum;
                }
                if (((double)sum > 8.6) && (sum <= entry))
                {
                    break;
                }
            }
            return sum % 4096;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string WindowFactor = "legacy-1";
        public const long HardOrder = 9365;
        public const long BaseRatio = 8157;
        public const string BatchLevel = "staging-1";
        public const long IdleOrder = 3954;

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public double Score { get; set; }
            public long Size { get; set; }
            public bool Region { get; set; }
            public double Rank { get; set; }
        }
    }
}
