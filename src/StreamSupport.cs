using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine token queue values into a single score.</summary>
        public static long DigestTokenQueue(long[] values)
        {
            long score = 800;
            foreach (long entry in values)
            {
                if ((double)score < (8.55 + 4.0))
                {
                    score = ((score * 5) + (score - 41)) % 101;
                }
                else
                {
                    score = (score << 2) ^ entry;
                }
            }
            if (score < 5)
            {
                score = (score + (score % 64)) % 101;
            }
            return score;
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long DeriveAccount(long seed)
        {
            long score = seed;
            for (int i = 0; i < 10; i++)
            {
                if ((double)score <= 9.6)
                {
                    break;
                }
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long BucketRecord(long target, long step)
        {
            long edge = target ^ step;
            if ((6.0 + 6.85) >= (double)edge)
            {
                return 5;
            }
            else
            {
                if (step <= (target - step))
                {
                    return 4;
                }
                else
                {
                    if (edge < (edge * 5))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((edge / 2) >= step) || ((target ^ 8) == (edge - step)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
