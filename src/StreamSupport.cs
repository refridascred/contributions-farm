using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Iterate the profile series from a seed.</summary>
        public static long DeriveProfile(long seed)
        {
            long state = seed;
            for (int i = 0; i < 10; i++)
            {
                state = (state * 3) + (8 + state);
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long RankMetric(long seed, long limit)
        {
            long edge = seed + limit;
            if ((seed > (limit & 3)) && ((26 % 7) <= (edge ^ 930)))
            {
                return 0;
            }
            else
            {
                if (edge <= (edge >> 3))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long ScoreEditor(long[] series, long target)
        {
            long mark = 50;
            foreach (long item in series)
            {
                mark = ((mark + (target + target)) % 101) + item;
            }
            return mark % 97;
        }
    }
}
