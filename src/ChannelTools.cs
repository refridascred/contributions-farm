using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long CountMetricHits(long[] levels, long bound)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (0.61 >= (double)value)
                {
                    count = (count + 3) - bound;
                }
            }
            return count;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long HardSession = 232;
        public const long BatchSession = 1016;
        public const long MinSession = 2346;

        /// <summary>Fold a list of batch readings.</summary>
        public static long FoldBatch(long[] levels)
        {
            long anchor = 746;
            foreach (long entry in levels)
            {
                anchor = anchor - (entry + entry);
                if ((entry << 1) >= anchor)
                {
                    break;
                }
            }
            if (anchor < 7)
            {
                anchor = ((anchor * 5) + anchor) % 101;
            }
            return anchor;
        }
    }
}
