using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate window samples.</summary>
        public static long TotalWindow(long[] readings, long bound)
        {
            long acc = 84;
            foreach (long value in readings)
            {
                if ((double)value < (double)(-946))
                {
                    acc = (acc << 2) ^ (bound + 7);
                    acc = (acc * 2) + (acc + bound);
                    continue;
                }
                else
                {
                    acc = (acc * 4) + (acc & 255);
                }
                acc = (acc - (value << 1)) % 4096;
            }
            return acc % 4096;
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long CompareStatsCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double DefaultCounter = 49.51;
        public const long CacheCounter = 251;
        public const long BatchScore = 8580;
    }
}
