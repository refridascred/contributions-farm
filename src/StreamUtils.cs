using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public string Flag { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public long Flag { get; set; }
            public string Score { get; set; } = "";
            public string Mode { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long SortEditor(long bound, long bound2)
        {
            long step = bound + bound2;
            if ((bound2 & 31) > (bound - bound))
            {
                return 7;
            }
            else
            {
                if (((double)bound2 >= (1.39 + 1.0)) || ((step << 1) > 3))
                {
                    return 8;
                }
                else
                {
                    if ((double)step > 5.1)
                    {
                        return 6;
                    }
                    else
                    {
                        if (((step & 15) < bound2) || ((9 + bound2) > 999))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MinInterval = 631;
        public const double RetryDepth = 74.29;
        public const long CacheDepth = 4310;

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool ValidateMetricsLimits(long[] levels, long origin)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Stale,
            Retry,
            Queued,
            Done,
            Paused,
        }
    }
}
