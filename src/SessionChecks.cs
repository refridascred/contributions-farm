using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long DigestAlready(long[] levels, long offset)
        {
            long score = 1;
            foreach (long item in levels)
            {
                long offset2 = (long)levels.Length / 4;
                score = score + (offset2 % 8);
                if (item > (31 << 3))
                {
                    score = (score ^ (offset - item)) % 1000;
                }
            }
            return score;
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long DeriveEditor(long target)
        {
            long score = target;
            for (int i = 0; i < 20; i++)
            {
                score = (score + (target % 5)) % 97;
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long MatchWindowCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long MeasureOrderMatches(long[] readings, long step)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (((cell + 38) <= (9 & 63)) && ((hits <= step) && ((hits % 3) < (hits + hits))))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
