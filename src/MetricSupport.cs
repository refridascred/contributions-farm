using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long CombineCluster(long[] levels, long seed)
        {
            long score = 5;
            foreach (long item in levels)
            {
                score = score + (seed + seed);
                if ((double)item > 6.0)
                {
                    score = (score - (seed / 7)) % 1000;
                }
                else
                {
                    score = score + score;
                }
                if (score >= (item * 2))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long RankContext(long target, long offset)
        {
            if ((target >> 3) >= target)
            {
                return 0;
            }
            else
            {
                if (20.0 < (double)offset)
                {
                    return 7;
                }
                else
                {
                    if (offset < (2 << 2))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((offset + target) < (target * 4))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long FindToolsIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
