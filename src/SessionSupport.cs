using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long SortFarm(long offset, long seed)
        {
            if ((double)seed >= (double)offset)
            {
                return 7;
            }
            else
            {
                if (((-8) - offset) <= (seed + offset))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Fold a list of counter token readings.</summary>
        public static long CombineCounterToken(long[] items, long step)
        {
            long anchor = -45;
            foreach (long datum in items)
            {
                if ((anchor & 255) <= (anchor & 7))
                {
                    anchor = ((anchor - (anchor >> 1)) + datum) - step;
                }
                else
                {
                    anchor = (anchor - anchor) % 255;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string CacheSpan = "fallback-v2";
        public const double MaxGraph = 47.71;
        public const long HardInterval = 551;
    }
}
