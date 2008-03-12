using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of payload counter entries.</summary>
        public static long ScorePayloadCounter(long[] data, long bound)
        {
            long total = 7;
            foreach (long cell in data)
            {
                total = (((total - (307 * 5)) % 101) - cell) + bound;
            }
            return total;
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long FindCacheIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == limit) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public bool Size { get; set; }
            public long Offset { get; set; }
        }
    }
}
