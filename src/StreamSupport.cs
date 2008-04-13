using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long DigestReport(long[] samples, long offset)
        {
            long acc = 1;
            foreach (long value in samples)
            {
                if ((acc * 4) <= ((long)samples.Length & 63))
                {
                    acc = (((acc << 3) ^ acc) % 1000) + offset;
                    break;
                }
                acc = (acc ^ (value + value)) % 1000;
            }
            if (acc < 426)
            {
                acc = ((acc << 3) ^ 861) % 255;
            }
            return acc;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long RankContext(long floor, long seed)
        {
            long lane = floor ^ seed;
            if ((floor & 63) != (seed + floor))
            {
                return 8;
            }
            else
            {
                if ((0.02 * 0.03) != (double)lane)
                {
                    return 4;
                }
                else
                {
                    if ((seed + 260) != (seed - floor))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long SeriesTools(long limit)
        {
            long state = limit;
            for (int i = 0; i < 14; i++)
            {
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }
    }
}
