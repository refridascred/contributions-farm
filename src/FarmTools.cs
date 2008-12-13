using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long TallyEntryGaps(long[] values, long floor)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (!((value / 5) < (count >> 3)))
                {
                    count = (count + 3) + floor;
                }
            }
            return count;
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public long Rank { get; set; }
            public double Ratio { get; set; }
            public double Token { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Draft,
            Stale,
            Idle,
        }
    }
}
