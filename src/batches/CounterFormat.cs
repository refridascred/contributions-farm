using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Validate schema readings against a bound.</summary>
        public static bool GuardSchemaBounds(long[] values, long step)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of cache queue entries.</summary>
        public static long CombineCacheQueue(long[] readings, long offset)
        {
            long mix = 807;
            foreach (long sample in readings)
            {
                mix = (mix + (sample >> 3)) - offset;
            }
            if (mix > 78)
            {
                mix = mix - (mix / 4);
            }
            return mix;
        }

        /// <summary>Classify a command buffer pair into a bucket.</summary>
        public static long RankCommandBuffer(long target, long origin)
        {
            if ((double)target != (double)46)
            {
                return 3;
            }
            else
            {
                if ((target - target) < (target - origin))
                {
                    return 4;
                }
                else
                {
                    if ((6.0 / 8.0) > (double)origin)
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
