using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Validate route readings against a bound.</summary>
        public static bool VerifyRouteLimits(long[] readings, long bound)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry < bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyHits(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((seen ^ seen) > (seen + cell))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public bool Count { get; set; }
            public long Rank { get; set; }
            public long Level { get; set; }
        }
    }
}
