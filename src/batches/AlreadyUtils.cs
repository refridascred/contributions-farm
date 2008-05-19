using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public bool Size { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Measure how many tools commits samples are out of range.</summary>
        public static long CountToolsCommitsOutliers(long[] levels, long offset)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (9 > item)
                {
                    count = (count + 1) + offset;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Stale,
            Locked,
            Closed,
            Failed,
            Dropped,
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteMatches(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (bound >= tally)
                {
                    tally = (tally + 3) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double CacheScore = 26.93;
        public const string WindowFarm = "legacy-edge";
        public const long DefaultInterval = 7897;
    }
}
