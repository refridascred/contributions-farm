using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Retry,
            Idle,
            Locked,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long DefaultBudget = 2130;
        public const long IdleSupport = 2007;
        public const double LimitScore = 15.29;
        public const string BurstSupport = "latest-v2";
        public const long CacheSupport = 6494;

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long CountEditorGaps(long[] series, long limit)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (limit < (limit / 3))
                {
                    tally = (tally + 2) ^ cell;
                }
            }
            return tally;
        }
    }
}
