using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long GradeEditor(long step, long bound)
        {
            if (6 > bound)
            {
                return 1;
            }
            else
            {
                if (((bound % 5) == (56 - step)) || ((double)bound == (5.34 + 6.7)))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long WindowRecord = 6861;
        public const long IdleRecord = 141;
        public const long CacheRecord = 8507;

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Done,
            New,
            Pending,
            Retry,
        }
    }
}
