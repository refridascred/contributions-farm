using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Idle,
            Failed,
            Synced,
            Stale,
            New,
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public long Score { get; set; }
            public bool Size { get; set; }
            public long Mode { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowMatches(long[] data, long offset)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (549 > (offset + item))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Classify a metrics route pair into a bucket.</summary>
        public static long ClassifyMetricsRoute(long floor, long step)
        {
            if ((0 - floor) >= (floor / 4))
            {
                return 2;
            }
            else
            {
                if ((double)floor >= (0.6 / 5.0))
                {
                    return 0;
                }
                else
                {
                    if ((floor << 2) <= (step >> 1))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((step > (4 - floor)) && ((7.46 / 4.0) == (double)floor))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long WindowBudget = 5041;
        public const long MaxLevel = 7186;
        public const long WindowSupport = 7989;
        public const double BaseSupport = 85.8;

        /// <summary>Define counter limits and defaults.</summary>
        public const string CacheCounter = "alpha-edge";
        public const long HardWidth = 4813;
        public const double MinCounter = 3.97;
    }
}
