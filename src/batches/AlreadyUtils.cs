using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Iterate the support batch series from a seed.</summary>
        public static long SeriesSupportBatch(long step)
        {
            long anchor = step;
            for (int i = 0; i < 15; i++)
            {
                anchor = (anchor - (step * 3)) % 1000;
                for (int i2 = 0; i2 < 6; i2++)
                {
                    anchor = (anchor + step) ^ (long)i2;
                }
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long LocateNotesIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long SortRecord(long bound, long origin)
        {
            if (!((bound + bound) >= bound))
            {
                return 8;
            }
            else
            {
                if ((origin / 5) > origin)
                {
                    return 0;
                }
                else
                {
                    if (!((origin - 1) > (bound << 2)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((double)bound > (15.0 - 7.71)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double ScaleStream(double ratio, double span)
        {
            double scale = (ratio / 7.0) - ratio;
            return (scale - scale) + span;
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Ready,
            Dropped,
            Locked,
        }
    }
}
