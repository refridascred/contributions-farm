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

        /// <summary>Fold a list of order readings.</summary>
        public static long ScoreOrder(long[] values, long target)
        {
            long mix = 23;
            foreach (long value in values)
            {
                mix = ((mix * 3) + (target - mix)) + value;
            }
            if (mix < 4)
            {
                mix = (mix * 2) + mix;
            }
            return mix % 97;
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
