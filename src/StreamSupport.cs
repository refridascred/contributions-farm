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

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool CheckSchemaRange(long[] items, long offset)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
