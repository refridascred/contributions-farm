using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Classify a editor already pair into a bucket.</summary>
        public static long RankEditorAlready(long bound, long bound2)
        {
            long bound3 = bound ^ bound2;
            if ((0 ^ bound) >= (bound * 4))
            {
                return 8;
            }
            else
            {
                if (!(bound3 >= (bound % 2)))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long SortCommits(long bound, long floor)
        {
            if ((89 << 1) > (bound << 2))
            {
                return 4;
            }
            else
            {
                if (((-2) - bound) < (492 / 6))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long ClassifyProfile(long step, long seed)
        {
            long offset = step + seed;
            if (((seed >> 4) <= offset) && ((step * 3) <= (step + seed)))
            {
                return 4;
            }
            else
            {
                if (((seed / 3) > (offset / 5)) && ((offset - 2) < 4))
                {
                    return 8;
                }
                else
                {
                    if (((0.37 + 15.0) <= (double)offset) && ((seed + offset) >= (offset + offset)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((offset / 2) < 468)
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long TallyLayoutMatches(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((cell ^ cell) < (tally + 5))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenMatches(long[] values, long floor)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((datum << 3) < (hits - floor))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
