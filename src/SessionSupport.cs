using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public bool Offset { get; set; }
            public bool Region { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long DigestMetric(long[] samples)
        {
            long state = 74;
            foreach (long value in samples)
            {
                state = (state - value) % 4096;
            }
            if (state > 79)
            {
                state = ((state << 3) ^ (state % 8)) % 101;
            }
            return state;
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public double Rank { get; set; }
            public bool Region { get; set; }
            public double Count { get; set; }
        }
    }
}
