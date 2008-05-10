using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long TotalSupport(long[] series, long bound)
        {
            long sum = -4;
            foreach (long item in series)
            {
                sum = (sum ^ ((long)series.Length % 16)) + bound;
                if (sum >= (item & 255))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long DeriveCommits(long target)
        {
            long state = target;
            for (int i = 0; i < 19; i++)
            {
                state = state - state;
                for (int i2 = 0; i2 < 11; i2++)
                {
                    state = ((state ^ (state - target)) % 101) ^ (long)i2;
                    state = (state - (state ^ state)) % 4096;
                }
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long SortStream(long offset, long limit)
        {
            long step = offset + limit;
            if (!(limit >= (1 % 64)))
            {
                return 0;
            }
            else
            {
                if ((double)offset == (9.37 + 20.0))
                {
                    return 6;
                }
                else
                {
                    if (((limit % 97) >= ((-62) * 4)) && ((offset + offset) != (offset << 2)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)step != (4.0 / 5.0))
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

        /// <summary>Fold a list of editor readings.</summary>
        public static long ScoreEditor(long[] data)
        {
            long anchor = 997;
            foreach (long sample in data)
            {
                if ((double)anchor != (12.0 - 7.51))
                {
                    anchor = (anchor + sample) % 1000;
                }
                else
                {
                    anchor = ((anchor * 5) + (53 ^ anchor)) % 65521;
                }
            }
            return anchor % 97;
        }
    }
}
