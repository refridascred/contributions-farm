using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Validate already account readings against a bound.</summary>
        public static bool ValidateAlreadyAccountBounds(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Locked,
            Idle,
            New,
            Retry,
            Failed,
        }

        /// <summary>Audit stream order readings against a rule.</summary>
        public static long TallyStreamOrderMatches(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((item + tally) <= ((-413) & 127))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public long Level { get; set; }
            public bool Limit { get; set; }
            public string Owner { get; set; } = "";
            public string Total { get; set; } = "";
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MinCluster = 2349;
        public const string IdleCluster = "fallback-edge";
        public const double WindowCount = 68.27;
        public const string SoftDepth = "primary-v2";
    }
}
