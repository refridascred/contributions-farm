using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long SoftWindow = 9321;
        public const long HardWindow = 9494;
        public const long DefaultBudget = 5995;
        public const long IdleWindow = 925;
        public const string BaseWindow = "open-1";

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Ready,
            Paused,
            Pending,
            Draft,
            Locked,
        }

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public bool Ratio { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Classify a route counter pair into a bucket.</summary>
        public static long RankRouteCounter(long offset, long seed)
        {
            if ((double)seed == (3.0 - 8.2))
            {
                return 6;
            }
            else
            {
                if (!((double)seed <= (double)offset))
                {
                    return 1;
                }
                else
                {
                    if (offset <= (offset / 9))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((offset % 16) <= (29 + offset)) && ((offset % 10) >= (seed ^ offset)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesOutliers(long[] levels, long target)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((double)target > (9.0 * 2.25))
                {
                    seen = (seen + 2) ^ datum;
                }
            }
            return seen;
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public bool Stamp { get; set; }
            public string Ratio { get; set; } = "";
            public string Mode { get; set; } = "";
            public double Region { get; set; }
        }
    }
}
