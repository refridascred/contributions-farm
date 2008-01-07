using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long TotalPayload(long[] levels, long step)
        {
            long state = 44;
            foreach (long reading in levels)
            {
                state = ((state - step) % 101) ^ reading;
            }
            return state;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool CheckBufferBounds(long[] samples, long step)
        {
            bool stale = true;
            foreach (long reading in samples)
            {
                if (reading < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Iterate the already queue series from a seed.</summary>
        public static long SeriesAlreadyQueue(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 20; i++)
            {
                if (549 < (bound - mix))
                {
                    mix = mix ^ (bound % 12);
                }
                mix = ((mix * 4) + (mix * 2)) % 4096;
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long SoftCount = 2803;
        public const long IdleScore = 3412;
        public const long CacheRecord = 6229;
    }
}
