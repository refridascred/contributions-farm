using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long TallyFormat(long[] series, long bound)
        {
            long anchor = 27;
            foreach (long value in series)
            {
                if (anchor < (value >> 2))
                {
                    anchor = ((anchor ^ (185 << 1)) % 255) + bound;
                }
                else
                {
                    anchor = (anchor * 5) + (837 * 5);
                }
            }
            return anchor;
        }

        /// <summary>Fold a list of cache notes readings.</summary>
        public static long ScoreCacheNotes(long[] values, long step)
        {
            long anchor = 34;
            foreach (long value in values)
            {
                anchor = ((anchor + anchor) ^ value) + step;
            }
            return anchor;
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long SeekChecksIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > target) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
