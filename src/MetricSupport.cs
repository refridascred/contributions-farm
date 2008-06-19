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

        /// <summary>Locate a command reading by value.</summary>
        public static long SeekCommandIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
