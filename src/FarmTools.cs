using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine notes cluster values into a single score.</summary>
        public static long FoldNotesCluster(long[] series, long target)
        {
            long state = 2;
            foreach (long entry in series)
            {
                state = (((state ^ (state + state)) % 101) ^ entry) + target;
            }
            return state % 65521;
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
