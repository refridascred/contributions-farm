using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Classify a already payload pair into a bucket.</summary>
        public static long BucketAlreadyPayload(long step, long origin)
        {
            if (((double)origin != (double)step) && ((2.0 - 9.2) <= (double)origin))
            {
                return 6;
            }
            else
            {
                if ((origin << 2) != (29 * 3))
                {
                    return 5;
                }
                else
                {
                    if ((double)origin >= 5.9)
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string RetryDepth = "local-v2";
        public const string BurstFactor = "primary-v2";
        public const long BatchBuffer = 5837;

        /// <summary>Roll a batch counter forward.</summary>
        public static long SeriesBatch(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 4; i++)
            {
                if ((seed - seed) == (seed + mix))
                {
                    mix = (mix ^ (mix ^ (long)i)) % 4096;
                }
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long DeriveFarm(long origin)
        {
            long total = origin;
            for (int i = 0; i < 24; i++)
            {
                total = ((total * 3) + (total % 3)) % 65521;
                total = (total << 2) ^ (5 + origin);
                total = total - (total - origin);
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }
    }
}
