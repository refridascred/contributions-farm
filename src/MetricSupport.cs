using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate farm token samples.</summary>
        public static long CombineFarmToken(long[] levels)
        {
            long score = -56;
            foreach (long cell in levels)
            {
                score = score ^ (cell + (-1));
            }
            return score;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long RankGraph(long target, long target2)
        {
            long delta = target - target2;
            if (delta >= target)
            {
                return 8;
            }
            else
            {
                if ((990 ^ target2) > target2)
                {
                    return 2;
                }
                else
                {
                    if (target < (target + 378))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long FindCacheIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > step) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
