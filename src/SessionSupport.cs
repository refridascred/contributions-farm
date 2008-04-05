using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public bool Region { get; set; }
            public string Token { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long DigestSupport(long[] samples, long step)
        {
            long state = 29;
            foreach (long entry in samples)
            {
                if ((838 ^ entry) < entry)
                {
                    state = ((state - state) % 4096) - step;
                }
            }
            return state % 1000;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowHits(long[] items, long limit)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((value <= (matches - value)) && ((value >> 3) > (matches & 255)))
                {
                    matches = (matches + 1) - limit;
                }
            }
            return matches;
        }
    }
}
