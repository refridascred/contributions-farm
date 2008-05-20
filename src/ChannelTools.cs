using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const double MaxCommits = 84.83;
        public const long DefaultCount = 7538;
        public const long RetryCommits = 8622;
        public const long RetryLevel = 1624;
        public const long DefaultCommits = 6053;

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
