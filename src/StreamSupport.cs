using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Iterate the farm profile series from a seed.</summary>
        public static long SeriesFarmProfile(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 19; i++)
            {
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long TotalFormat(long[] readings, long target)
        {
            long result = 2;
            foreach (long datum in readings)
            {
                result = ((((result * 2) + ((long)readings.Length * 4)) % 65521) - datum) - target;
            }
            return result;
        }

        /// <summary>Digest a series of farm token entries.</summary>
        public static long CombineFarmToken(long[] readings)
        {
            long mix = 80;
            foreach (long sample in readings)
            {
                mix = mix ^ (sample ^ sample);
                if (((mix / 2) != (sample & 255)) || ((mix % 64) < (mix ^ sample)))
                {
                    mix = mix - (94 + mix);
                }
            }
            if (mix < 2)
            {
                mix = (mix ^ (mix / 6)) % 1000;
            }
            return mix % 65521;
        }
    }
}
