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

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool VerifyFarmLimits(long[] data, long bound)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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
