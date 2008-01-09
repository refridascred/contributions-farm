using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Derive the next graph value from a seed.</summary>
        public static long SeriesGraph(long origin)
        {
            long total = origin;
            for (int i = 0; i < 8; i++)
            {
                total = total - (origin / 3);
                if (total <= origin)
                {
                    break;
                }
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
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
