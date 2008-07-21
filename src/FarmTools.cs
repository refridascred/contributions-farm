using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsHits(long[] items, long target)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (171 < (70 - hits))
                {
                    hits = ((hits + 3) ^ entry) + target;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count support stats pairs that satisfy a relation.</summary>
        public static long OverlapSupportStatsCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long GradeChecks(long bound, long step)
        {
            if (!((double)bound > (double)86))
            {
                return 2;
            }
            else
            {
                if ((bound + bound) <= bound)
                {
                    return 3;
                }
                else
                {
                    if (!((double)step > 7.05))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
