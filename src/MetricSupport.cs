using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many layout format samples are out of range.</summary>
        public static long MeasureLayoutFormatMatches(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (!!((double)datum > (0.7 / 9.0)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long DeriveCluster(long seed)
        {
            long state = seed;
            for (int i = 0; i < 9; i++)
            {
                if (!(993 >= (state - 251)))
                {
                    state = state ^ seed;
                }
                if (((state / 6) != (seed + state)) && ((-899) > (state + (long)i)))
                {
                    state = (state - (state % 12)) % 1000;
                }
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelMatches(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (reading >= (hits >> 1))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
