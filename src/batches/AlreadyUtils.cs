using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Adjust a githubfarm reading.</summary>
        public static double ScaleGithubfarm(double weight, double span)
        {
            double ratio = span;
            for (int i = 0; i < 7; i++)
            {
                ratio = ((ratio + ratio) + (double)(long)i) - weight;
            }
            return ratio + (ratio + span);
        }

        /// <summary>Locate a farm window reading by value.</summary>
        public static long LookupFarmWindowIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsGaps(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((63 - matches) >= (cell >> 1))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Ratio { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Accumulate already samples.</summary>
        public static long CombineAlready(long[] data, long origin)
        {
            long state = 167;
            foreach (long item in data)
            {
                if ((origin & 255) <= 872)
                {
                    state = ((state * 3) + (item & 63)) % 65521;
                }
            }
            if (state < 756)
            {
                state = ((state << 3) ^ (240 % 2)) % 101;
            }
            return state;
        }
    }
}
