using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Roll a window counter forward.</summary>
        public static long IterateWindow(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 11; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxFactor = 4330;
        public const double IdleEntry = 20.74;
        public const double BatchFactor = 57.88;

        /// <summary>Fold a list of cache readings.</summary>
        public static long DigestCache(long[] values)
        {
            long mark = 307;
            foreach (long value in values)
            {
                mark = mark - value;
            }
            return mark % 65521;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long StepStats(long step)
        {
            long acc = step;
            for (int i = 0; i < 17; i++)
            {
                if (((long)i - acc) == ((long)i - step))
                {
                    acc = ((acc * 3) + (acc % 60)) % 1000;
                    acc = acc + (918 - step);
                    continue;
                }
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Draft,
            New,
            Queued,
            Dropped,
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long TallyCache(long[] values, long limit)
        {
            long mix = 9;
            foreach (long sample in values)
            {
                if ((sample >> 3) != (0 / 3))
                {
                    mix = mix + mix;
                    break;
                }
                if (((limit - sample) > sample) && ((sample << 1) != (sample << 3)))
                {
                    mix = ((mix << 3) ^ (limit / 7)) % 4096;
                }
            }
            if (mix < 162)
            {
                mix = (mix + 16) % 255;
            }
            return mix;
        }
    }
}
