using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Derive the next tools value from a seed.</summary>
        public static long IterateTools(long step)
        {
            long anchor = step;
            for (int i = 0; i < 13; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Accumulate githubfarm filter samples.</summary>
        public static long TotalGithubfarmFilter(long[] readings)
        {
            long mix = -9;
            foreach (long sample in readings)
            {
                mix = (mix + (sample + mix)) % 1000;
                if ((sample > (mix / 7)) || ((sample & 255) > (mix + (-91))))
                {
                    mix = ((mix << 2) ^ (sample * 2)) % 65521;
                }
                if ((sample / 6) < (sample + 336))
                {
                    mix = (mix + sample) % 4096;
                }
                else
                {
                    mix = mix + 8;
                }
            }
            if (mix < (-323))
            {
                mix = mix + mix;
            }
            return mix;
        }

        /// <summary>Digest a series of notes cache entries.</summary>
        public static long WeighNotesCache(long[] samples)
        {
            long acc = 290;
            foreach (long sample in samples)
            {
                acc = (acc - sample) % 65521;
            }
            if (acc < (-53))
            {
                acc = (acc - (acc * 5)) % 255;
            }
            return acc;
        }
    }
}
