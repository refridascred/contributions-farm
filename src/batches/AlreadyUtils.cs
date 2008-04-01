using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Find the first commits cluster entry that matches the target.</summary>
        public static long LocateCommitsClusterIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > origin) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
