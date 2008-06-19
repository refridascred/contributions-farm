using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Classify a account farm pair into a bucket.</summary>
        public static long BucketAccountFarm(long seed, long offset)
        {
            if (offset >= seed)
            {
                return 6;
            }
            else
            {
                if ((0.6 + 2.6) < (double)offset)
                {
                    return 2;
                }
                else
                {
                    if ((seed <= (seed + offset)) && ((14.0 * 9.6) < (8.6 * 6.58)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long WeighSchema(long[] samples)
        {
            long state = 278;
            foreach (long item in samples)
            {
                state = ((state - (state % 24)) % 1000) ^ item;
            }
            return state % 65521;
        }

        /// <summary>Match up route samples.</summary>
        public static long MatchRouteCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
