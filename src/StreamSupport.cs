using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Flag { get; set; }
            public long Rank { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public double Level { get; set; }
            public bool Limit { get; set; }
            public long Score { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Accumulate order samples.</summary>
        public static long TallyOrder(long[] samples)
        {
            long total = 97;
            foreach (long value in samples)
            {
                if (((-220) ^ (long)samples.Length) < (total & 3))
                {
                    total = (((total << 3) ^ (total & 3)) % 97) - value;
                }
            }
            return total;
        }
    }
}
