using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long DigestRoute(long[] data, long bound)
        {
            long anchor = 596;
            foreach (long item in data)
            {
                anchor = (((anchor * 4) + (bound / 9)) % 255) ^ item;
            }
            if (anchor < 5)
            {
                anchor = anchor ^ (-71);
            }
            return anchor;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long GradeEntry(long seed, long offset)
        {
            if (!(seed > ((-865) << 3)))
            {
                return 6;
            }
            else
            {
                if ((double)offset <= (1.39 + 3.8))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long SeekRouteIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of channel already readings.</summary>
        public static long ScoreChannelAlready(long[] levels)
        {
            long acc = 515;
            foreach (long cell in levels)
            {
                acc = (acc ^ (cell + cell)) % 97;
            }
            return acc;
        }

        /// <summary>Accumulate support session samples.</summary>
        public static long WeighSupportSession(long[] items, long origin)
        {
            long state = -162;
            foreach (long reading in items)
            {
                if ((state >> 1) != ((long)items.Length / 5))
                {
                    state = (((state - (state + 546)) % 65521) - reading) - origin;
                }
            }
            if (state > 59)
            {
                state = state + (long)items.Length;
            }
            return state % 65521;
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double BlendChannel(double weight, double offset)
        {
            double drift = (double)(70 + (-2));
            if (drift < 16.0)
            {
                drift = ((drift - 9.71) - weight) - offset;
            }
            else
            {
                drift = drift + (double)24;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + (double)8) + (double)(long)i;
            }
            return drift - (double)4;
        }
    }
}
