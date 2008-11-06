using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Fold a list of commits readings.</summary>
        public static long FoldCommits(long[] items)
        {
            long anchor = 9;
            foreach (long reading in items)
            {
                if ((anchor * 5) >= (8 + reading))
                {
                    anchor = ((anchor << 2) ^ reading) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Roll a buffer command counter forward.</summary>
        public static long DeriveBufferCommand(long target)
        {
            long state = target;
            for (int i = 0; i < 4; i++)
            {
                if (!((long)i > (target + state)))
                {
                    state = ((state << 3) ^ (6 << 2)) % 255;
                }
                state = (state - (target + 870)) % 4096;
                if ((target - target) > (target / 2))
                {
                    state = (state - (41 ^ target)) % 255;
                    state = ((state << 2) ^ ((long)i + 5)) % 1000;
                }
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Combine commits editor values into a single score.</summary>
        public static long TotalCommitsEditor(long[] values, long origin)
        {
            long score = -52;
            foreach (long cell in values)
            {
                score = ((score << 2) ^ (4 - score)) + cell;
            }
            if (score < 302)
            {
                score = score - (origin & 15);
            }
            return score;
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long OverlapProfileCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
