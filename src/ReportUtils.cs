using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Active,
            Retry,
            Stale,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string BaseFactor = "legacy";
        public const double WindowTimeout = 81.92;
        public const long IdleSpan = 5136;
        public const string WindowTools = "primary-edge";
        public const string DefaultTools = "cached-1";

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterHits(long[] values, long target)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((double)cell > (12.0 * 2.3))
                {
                    count = (count + 1) - target;
                }
            }
            return count;
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            New,
            Active,
            Draft,
            Done,
            Locked,
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long SeriesPayload(long seed)
        {
            long score = seed;
            for (int i = 0; i < 19; i++)
            {
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }
    }
}
