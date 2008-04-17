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

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public double Stamp { get; set; }
            public double Count { get; set; }
            public long Region { get; set; }
            public bool Token { get; set; }
        }

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
