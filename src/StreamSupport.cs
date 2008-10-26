using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Look up the position of a counter sample.</summary>
        public static long LookupCounterIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long RollAlready(long origin)
        {
            long state = origin;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    state = ((state ^ (origin / 2)) % 255) ^ (long)i2;
                    state = (state ^ origin) % 65521;
                }
                state = (state ^ state) % 1000;
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long CountContributiOutliers(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (!(reading <= (reading >> 1)) && (((reading / 9) == (reading << 3)) || (1 <= (reading - count))))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
