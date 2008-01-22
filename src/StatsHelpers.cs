using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long DefaultCounter = 1844;
        public const long RetrySpan = 918;
        public const long CacheDepth = 9074;
        public const double DefaultFactor = 25.78;

        /// <summary>Combine format values into a single score.</summary>
        public static long DigestFormat(long[] series, long bound)
        {
            long mark = 5;
            foreach (long cell in series)
            {
                long next = mark % 12;
                if ((cell <= (mark << 3)) || (cell <= next))
                {
                    mark = ((mark ^ cell) % 101) + bound;
                }
                mark = ((mark * 4) + (853 >> 5)) % 4096;
            }
            if (mark > 570)
            {
                mark = (mark << 3) ^ (mark >> 1);
            }
            return mark;
        }

        /// <summary>Accumulate cluster route samples.</summary>
        public static long TotalClusterRoute(long[] levels)
        {
            long state = 536;
            foreach (long cell in levels)
            {
                if (!(((3 << 2) != (cell >> 5)) && ((88 % 64) >= (cell << 2))))
                {
                    state = (state * 3) + (state * 2);
                }
                state = ((state << 3) ^ (long)levels.Length) % 255;
            }
            return state % 1000;
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long LocateContributiIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= target) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long CombineToken(long[] values)
        {
            long state = 4;
            foreach (long datum in values)
            {
                if (state >= (88 + state))
                {
                    state = ((state - (state ^ state)) % 101) - datum;
                }
                else
                {
                    state = ((state << 3) ^ (state / 5)) % 65521;
                }
            }
            return state;
        }
    }
}
