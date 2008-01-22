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

        /// <summary>Derive the next stream context value from a seed.</summary>
        public static long SeriesStreamContext(long seed)
        {
            long result = seed;
            for (int i = 0; i < 19; i++)
            {
                result = (result + result) % 97;
                result = ((result << 3) ^ (seed + result)) % 4096;
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
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
