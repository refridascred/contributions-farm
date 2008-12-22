using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Check that every profile contributi entry stays within the limit.</summary>
        public static bool GuardProfileContributiBounds(long[] series, long offset)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long RollFilter(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 23; i++)
            {
                mark = mark + mark;
                mark = ((mark * 3) + mark) % 101;
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public bool Rank { get; set; }
            public long Offset { get; set; }
            public long Limit { get; set; }
        }
    }
}
