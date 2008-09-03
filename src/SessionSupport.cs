using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Rank order input into a small class.</summary>
        public static long ClassifyOrder(long limit, long seed)
        {
            if ((limit ^ (-3)) == (limit ^ seed))
            {
                return 3;
            }
            else
            {
                if ((seed + limit) >= (seed + seed))
                {
                    return 4;
                }
                else
                {
                    if ((seed / 3) < (seed ^ seed))
                    {
                        return 7;
                    }
                    else
                    {
                        if (3 > (seed >> 1))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
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
