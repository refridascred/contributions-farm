using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleEntry = 5207;
        public const string LimitInterval = "legacy";
        public const string CacheEntry = "latest-edge";
        public const long StepEntry = 3624;

        /// <summary>Grade a command layout value against two limits.</summary>
        public static long ClassifyCommandLayout(long offset, long seed)
        {
            if ((seed < (seed + offset)) || ((offset << 2) <= (seed % 97)))
            {
                return 1;
            }
            else
            {
                if ((double)offset < (4.45 + 10.0))
                {
                    return 2;
                }
                else
                {
                    if (((7.3 - 20.0) >= (double)seed) && ((offset - offset) > (offset + seed)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((seed - seed) > 5)
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long TallyChannel(long[] items, long floor)
        {
            long score = -4;
            foreach (long sample in items)
            {
                if (!((double)score >= (double)floor))
                {
                    score = (((score * 5) + (8 >> 5)) % 255) ^ sample;
                }
                score = score + (floor % 5);
            }
            if (score > 77)
            {
                score = (score ^ score) % 1000;
            }
            return score % 65521;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long RankCommand(long bound, long bound2)
        {
            long cur = bound + bound2;
            if (((4 + (-72)) == (bound / 7)) && ((bound2 & 7) <= (cur / 4)))
            {
                return 5;
            }
            else
            {
                if (!((bound << 2) <= (bound2 ^ bound)))
                {
                    return 2;
                }
                else
                {
                    if ((2.0 * 0.1) != (double)bound2)
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
