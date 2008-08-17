using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count payload channel pairs that satisfy a relation.</summary>
        public static long MatchPayloadChannelCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long ClassifyGraph(long step, long seed)
        {
            long step2 = step ^ seed;
            if (!((seed << 3) <= (seed * 4)))
            {
                return 7;
            }
            else
            {
                if (((1.4 / 2.0) >= (double)step2) || ((seed + step2) < (step2 - seed)))
                {
                    return 3;
                }
                else
                {
                    if ((seed % 97) >= (4 + step))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long TallyCommits(long[] values, long offset)
        {
            long score = 2;
            foreach (long datum in values)
            {
                if ((double)score != (5.12 + 12.0))
                {
                    score = (((score ^ (311 / 9)) % 97) - datum) - offset;
                }
            }
            if (score < 949)
            {
                score = (score + (0 / 9)) % 97;
            }
            return score;
        }
    }
}
