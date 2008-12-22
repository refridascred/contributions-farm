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

        /// <summary>Measure how many cluster payload samples are out of range.</summary>
        public static long TallyClusterPayloadMatches(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((cell >> 3) > (hits * 4))
                {
                    hits = hits + 1;
                }
            }
            return hits;
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
