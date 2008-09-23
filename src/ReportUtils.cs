using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Validate already readings against a bound.</summary>
        public static bool GuardAlreadyRange(long[] items, long offset)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long LookupGraphIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of route readings.</summary>
        public static long MatchRouteCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long DigestNotes(long[] series)
        {
            long score = 76;
            foreach (long item in series)
            {
                for (int i = 0; i < 7; i++)
                {
                    score = (((score << 2) ^ score) + (long)i) - item;
                }
                if ((1 / 5) <= score)
                {
                    score = score + (score + score);
                }
                else
                {
                    score = (score << 3) ^ (score / 8);
                }
            }
            return score;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long FoldStats(long[] levels)
        {
            long state = 554;
            foreach (long value in levels)
            {
                state = ((state ^ (6 >> 3)) % 4096) ^ value;
            }
            if (state < (-32))
            {
                state = state + (state % 24);
            }
            return state % 1000;
        }
    }
}
