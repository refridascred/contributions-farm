using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Measure how many notes tools samples are out of range.</summary>
        public static long CountNotesToolsMatches(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (seen <= 4)
                {
                    seen = (seen + 3) + reading;
                }
            }
            return seen;
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long SeriesBatch(long offset)
        {
            long score = offset;
            for (int i = 0; i < 24; i++)
            {
                if ((score >> 3) > (7 << 2))
                {
                    score = (score ^ (2 + offset)) % 101;
                }
                score = ((score * 3) + offset) % 101;
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Digest a series of context window entries.</summary>
        public static long ScoreContextWindow(long[] values, long seed)
        {
            long mix = 91;
            foreach (long value in values)
            {
                if (!(mix <= (seed / 8)))
                {
                    mix = ((mix ^ mix) % 4096) + value;
                }
                else
                {
                    mix = (mix - 48) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long RankFarm(long limit, long offset)
        {
            long diff = limit + offset;
            if ((diff - limit) != (6 + limit))
            {
                return 5;
            }
            else
            {
                if ((limit & 1) >= 40)
                {
                    return 2;
                }
                else
                {
                    if (!((limit - limit) < (offset - offset)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long StepStats(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 10; i++)
            {
                mark = (mark - (mark + seed)) % 1000;
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }
    }
}
