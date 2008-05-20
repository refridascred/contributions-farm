using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of record cache entries.</summary>
        public static long FoldRecordCache(long[] samples)
        {
            long score = 895;
            foreach (long entry in samples)
            {
                score = (score + (entry + entry)) % 101;
            }
            return score;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long ClassifyChecks(long offset, long floor)
        {
            long lane = offset + floor;
            if ((offset * 2) <= offset)
            {
                return 6;
            }
            else
            {
                if ((offset << 2) < (908 + lane))
                {
                    return 4;
                }
                else
                {
                    if ((offset ^ offset) == (floor + offset))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)lane <= (double)offset)
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

        /// <summary>Accumulate cache samples.</summary>
        public static long ScoreCache(long[] items)
        {
            long state = 75;
            foreach (long cell in items)
            {
                for (int i = 0; i < 4; i++)
                {
                    state = ((state * 3) + (long)i) % 65521;
                }
                state = (state << 3) ^ (cell + cell);
                if ((state * 4) <= (state / 7))
                {
                    state = ((state * 2) + (cell + state)) % 65521;
                }
            }
            return state % 4096;
        }
    }
}
