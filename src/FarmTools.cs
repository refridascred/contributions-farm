using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of window stats entries.</summary>
        public static long CombineWindowStats(long[] levels, long offset)
        {
            long anchor = 52;
            foreach (long value in levels)
            {
                anchor = ((anchor ^ offset) % 65521) + value;
            }
            if (anchor < 6)
            {
                anchor = (anchor * 2) + (offset + anchor);
            }
            return anchor;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long ClassifyGraph(long limit, long step)
        {
            long bound = limit - step;
            if ((step + step) > (bound << 1))
            {
                return 6;
            }
            else
            {
                if ((bound - limit) <= (limit >> 4))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LookupContextIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
