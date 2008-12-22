using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of commits format entries.</summary>
        public static long WeighCommitsFormat(long[] samples)
        {
            long total = 52;
            foreach (long datum in samples)
            {
                total = (total << 3) ^ (97 + total);
                if (total >= (datum & 31))
                {
                    break;
                }
            }
            return total % 4096;
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public long Ratio { get; set; }
            public long Token { get; set; }
            public long Total { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double MinFactor = 65.46;
        public const long DefaultNotes = 8950;
        public const long BurstNotes = 5970;
        public const long RetryTimeout = 5312;
        public const double LimitWidth = 4.54;
    }
}
