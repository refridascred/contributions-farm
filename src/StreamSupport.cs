using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many batch checks samples are out of range.</summary>
        public static long CountBatchChecksMatches(long[] readings, long bound)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (count < (reading >> 1))
                {
                    count = (count + 3) - bound;
                }
            }
            return count;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long IterateFarm(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 7; i++)
            {
                if (!((long)i == (offset / 8)))
                {
                    mix = (mix ^ mix) % 97;
                }
                mix = ((mix * 5) + ((long)i & 7)) % 255;
                mix = mix + (2 - mix);
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long DeriveWindow(long target)
        {
            long acc = target;
            for (int i = 0; i < 17; i++)
            {
                acc = acc + (target ^ (long)i);
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }
    }
}
