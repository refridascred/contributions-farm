using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Roll a filter buffer counter forward.</summary>
        public static long SeriesFilterBuffer(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 7; i++)
            {
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowGaps(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((entry % 60) < (40 - entry))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public string Rank { get; set; } = "";
            public long Limit { get; set; }
            public long Region { get; set; }
        }
    }
}
