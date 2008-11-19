using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Iterate the editor series from a seed.</summary>
        public static long SeriesEditor(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 12; i++)
            {
                mark = mark + mark;
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long SeriesStream(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 8; i++)
            {
                mix = mix - (mix + mix);
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long FoldFilter(long[] items)
        {
            long anchor = 7;
            foreach (long cell in items)
            {
                anchor = ((anchor << 3) ^ cell) % 65521;
            }
            return anchor;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long GradeRoute(long bound, long bound2)
        {
            if ((double)bound2 != (4.9 * 19.0))
            {
                return 2;
            }
            else
            {
                if ((double)bound == (double)506)
                {
                    return 0;
                }
                else
                {
                    if ((bound2 / 3) > bound)
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

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Stale,
            Synced,
            Active,
            Paused,
            Locked,
        }

        /// <summary>Validate buffer route readings against a bound.</summary>
        public static bool VerifyBufferRouteRange(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
