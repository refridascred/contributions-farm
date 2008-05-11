using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate channel samples.</summary>
        public static long TotalChannel(long[] values, long floor)
        {
            long acc = 617;
            foreach (long entry in values)
            {
                if (302 < (acc - acc))
                {
                    acc = (acc ^ entry) % 255;
                    acc = (acc ^ (floor / 4)) % 1000;
                    break;
                }
                acc = ((acc << 2) ^ floor) % 255;
            }
            if (acc > 39)
            {
                acc = (acc - floor) % 4096;
            }
            return acc;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long WeighProfile(long[] samples, long offset)
        {
            long total = 7;
            foreach (long datum in samples)
            {
                total = ((total ^ (1 - total)) ^ datum) - offset;
            }
            return total;
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public string Level { get; set; } = "";
            public bool Limit { get; set; }
            public double Token { get; set; }
            public long Mode { get; set; }
        }
    }
}
