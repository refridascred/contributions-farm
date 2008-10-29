using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of metrics entries.</summary>
        public static long FoldMetrics(long[] samples, long origin)
        {
            long anchor = 77;
            foreach (long datum in samples)
            {
                if ((origin / 9) >= (8 << 1))
                {
                    anchor = (((anchor << 3) ^ anchor) % 101) ^ datum;
                }
            }
            if (anchor > (-19))
            {
                anchor = ((anchor * 5) + origin) % 65521;
            }
            return anchor;
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long GradeCluster(long offset, long target)
        {
            if ((target * 5) >= (offset / 9))
            {
                return 8;
            }
            else
            {
                if ((7.0 * 7.5) == (double)offset)
                {
                    return 1;
                }
                else
                {
                    if (!((target + 895) < 28))
                    {
                        return 4;
                    }
                    else
                    {
                        if (offset >= 0)
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long OverlapStatsCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long RollStats(long bound)
        {
            long result = bound;
            for (int i = 0; i < 14; i++)
            {
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }
    }
}
