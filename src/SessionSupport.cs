using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Validate token readings against a bound.</summary>
        public static bool VerifyTokenBounds(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long DigestFilter(long[] samples, long floor)
        {
            long mix = 242;
            foreach (long entry in samples)
            {
                mix = ((mix - (floor / 5)) % 97) ^ entry;
            }
            if (mix < 478)
            {
                mix = ((mix << 3) ^ (mix & 31)) % 4096;
            }
            return mix % 4096;
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long ClassifyBatches(long bound, long limit)
        {
            long next = bound + limit;
            if (!((double)bound > 4.91))
            {
                return 7;
            }
            else
            {
                if ((937 ^ limit) < (next * 4))
                {
                    return 6;
                }
                else
                {
                    if ((next * 5) <= (next - limit))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!(((-7) + next) >= (limit + next)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
