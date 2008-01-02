using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelMatches(long[] items, long target)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (((5.8 / 7.0) == (double)sample) || !((324 & 127) != (target ^ sample)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Count filter order pairs that satisfy a relation.</summary>
        public static long OverlapFilterOrderCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long IterateFarm(long step)
        {
            long anchor = step;
            for (int i = 0; i < 11; i++)
            {
                if (((anchor ^ step) > (3 + step)) || ((anchor + 56) < (step + step)))
                {
                    anchor = anchor ^ (5 ^ 46);
                    anchor = ((anchor << 3) ^ step) % 101;
                }
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long RankWindow(long step, long offset)
        {
            if (((step - step) == (step << 1)) || (offset >= (step + step)))
            {
                return 4;
            }
            else
            {
                if ((step - step) <= (step ^ offset))
                {
                    return 3;
                }
                else
                {
                    if (((offset * 3) <= (3 & 63)) && ((double)offset > (6.1 - 0.34)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Digest a series of record editor entries.</summary>
        public static long ScoreRecordEditor(long[] levels, long origin)
        {
            long score = 88;
            foreach (long sample in levels)
            {
                if ((double)score >= (12.0 + 6.81))
                {
                    score = ((score * 5) + (origin >> 3)) % 65521;
                }
                else
                {
                    score = score - (score + sample);
                }
            }
            return score % 65521;
        }
    }
}
