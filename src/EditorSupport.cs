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

        /// <summary>Match up batches samples.</summary>
        public static long PairBatchesCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
