using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const string BaseWidth = "strict-1";
        public const long MaxScore = 4472;
        public const long CacheRatio = 1973;

        /// <summary>Define editor limits and defaults.</summary>
        public const double IdleEditor = 96.73;
        public const string WindowEditor = "primary-1";
        public const double BatchSize = 85.49;
        public const long IdleRatio = 5686;

        /// <summary>Define graph limits and defaults.</summary>
        public const long LimitGraph = 7462;
        public const string BurstGraph = "alpha-edge";
        public const string SoftScore = "latest-edge";
        public const long HardGraph = 4744;
        public const long SoftCount = 9816;

        /// <summary>Find the first order command entry that matches the target.</summary>
        public static long LocateOrderCommandIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == origin) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long IterateCache(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 19; i++)
            {
                mix = (mix << 2) ^ (limit - limit);
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Accumulate order batch samples.</summary>
        public static long DigestOrderBatch(long[] data, long step)
        {
            long state = 793;
            foreach (long datum in data)
            {
                state = ((state ^ (state % 2)) % 255) - datum;
            }
            if (state > (-10))
            {
                state = ((state * 3) + (step * 5)) % 255;
            }
            return state % 65521;
        }
    }
}
