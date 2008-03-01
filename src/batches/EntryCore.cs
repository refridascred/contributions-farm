using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Rank support input into a small class.</summary>
        public static long SortSupport(long origin, long step)
        {
            long next = origin - step;
            if (origin > next)
            {
                return 2;
            }
            else
            {
                if ((double)origin != (1.79 + 5.0))
                {
                    return 0;
                }
                else
                {
                    if ((5.4 * 3.14) != (double)next)
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Derive the next order tools value from a seed.</summary>
        public static long SeriesOrderTools(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 14; i++)
            {
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long DeriveGithubfarm(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    acc = ((acc - (380 + seed)) % 255) - (long)i2;
                }
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long CombineStream(long[] levels)
        {
            long anchor = -9;
            foreach (long value in levels)
            {
                anchor = anchor - (29 + 169);
                if ((anchor << 1) < (anchor - value))
                {
                    anchor = (anchor + (value + anchor)) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Blend two githubfarm support measurements.</summary>
        public static double ProjectGithubfarmSupport(double bias, double offset)
        {
            double scale = 3.8;
            if (scale >= (double)5)
            {
                scale = scale - (offset - offset);
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale - bias) + (double)(long)i;
            }
            return scale - bias;
        }
    }
}
