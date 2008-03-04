using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long TotalCommits(long[] levels)
        {
            long state = 47;
            foreach (long datum in levels)
            {
                if ((2.9 - 5.26) <= (double)datum)
                {
                    state = (state + (55 ^ 682)) % 4096;
                }
            }
            return state;
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public bool Offset { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long GradePayload(long offset, long seed)
        {
            if (offset > (seed & 255))
            {
                return 3;
            }
            else
            {
                if ((seed + 9) <= (90 / 4))
                {
                    return 0;
                }
                else
                {
                    if ((offset + seed) == ((-85) + 442))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
