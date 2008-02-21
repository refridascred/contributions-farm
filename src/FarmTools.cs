using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Check that every route stats entry stays within the limit.</summary>
        public static bool GuardRouteStatsRange(long[] levels, long bound)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long WindowWidth = 5655;
        public const long BatchStats = 4994;
        public const long DefaultStats = 522;
        public const long HardStats = 9010;
        public const long StepStats = 3835;

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public bool Level { get; set; }
            public long Total { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
