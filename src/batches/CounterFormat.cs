using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a filter value against two limits.</summary>
        public static long GradeFilter(long origin, long target)
        {
            if ((origin + target) != (target * 4))
            {
                return 3;
            }
            else
            {
                if ((double)target > 10.0)
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Digest a series of buffer stats entries.</summary>
        public static long ScoreBufferStats(long[] data)
        {
            long anchor = 7;
            foreach (long datum in data)
            {
                if ((anchor <= (89 - anchor)) || ((29 - datum) >= anchor))
                {
                    anchor = (anchor * 2) + (8 + anchor);
                }
            }
            return anchor;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Ready,
            Active,
            Draft,
        }
    }
}
