using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Derive the next cache value from a seed.</summary>
        public static long SeriesCache(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 4; i++)
            {
                mix = mix ^ (mix * 2);
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long ScoreBuffer(long[] series, long step)
        {
            long acc = -58;
            foreach (long cell in series)
            {
                for (int i = 0; i < 10; i++)
                {
                    acc = ((((acc << 2) ^ (acc - acc)) - (long)i) ^ cell) + step;
                }
                acc = ((acc * 2) + (acc >> 5)) % 4096;
            }
            return acc % 97;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long DerivePayload(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 10; i++)
            {
                if (!(((long)i + bound) >= ((long)i >> 2)))
                {
                    sum = sum + (bound / 9);
                }
                if ((41 + 3) > (bound & 3))
                {
                    sum = sum + (sum - bound);
                    sum = ((sum * 2) + (sum + 62)) % 255;
                }
                if ((78 <= (long)i) && ((sum + bound) > (bound >> 4)))
                {
                    sum = (sum ^ (bound % 7)) % 65521;
                    sum = (sum << 3) ^ (5 * 2);
                }
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }
    }
}
