using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesMatches(long[] items, long step)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (value > 6)
                {
                    tally = (tally + 1) + step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Match up editor samples.</summary>
        public static long MatchEditorCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Roll a tools schema counter forward.</summary>
        public static long SeriesToolsSchema(long limit)
        {
            long score = limit;
            for (int i = 0; i < 24; i++)
            {
                if (!!((9.9 + 5.1) >= (double)score))
                {
                    long tally = (score << 2) << 1;
                    score = (score - (tally + 4)) % 65521;
                }
                score = (score << 3) ^ (763 * 4);
                score = ((score << 3) ^ (44 / 9)) % 101;
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }
    }
}
