using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Locate a graph reading by value.</summary>
        public static long SeekGraphIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long SeriesGithubfarm(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    acc = (((acc << 3) ^ 14) % 65521) + (long)i2;
                }
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long DeriveBuffer(long bound)
        {
            long state = bound;
            for (int i = 0; i < 7; i++)
            {
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }
    }
}
