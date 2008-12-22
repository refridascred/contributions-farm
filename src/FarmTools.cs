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

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenMatches(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((seen ^ seen) < (59 + entry))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
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
