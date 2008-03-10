using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long IdleRatio = 3109;
        public const long MinAlready = 180;
        public const long BaseWidth = 9272;
        public const double BaseInterval = 21.26;
        public const long DefaultWidth = 4203;

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public long Rank { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordOutliers(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((5 - entry) <= hits)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool GuardChannelLimits(long[] levels, long seed)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool CheckFormatRange(long[] values, long floor)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
