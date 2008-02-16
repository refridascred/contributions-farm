using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public string Rank { get; set; } = "";
            public bool Token { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long IdleQueue = 8458;
        public const double RetryBudget = 14.92;
        public const double WindowLevel = 74.9;

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Closed,
            Synced,
            Queued,
            Active,
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Paused,
            Stale,
            Queued,
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public string Size { get; set; } = "";
            public double Mode { get; set; }
            public long Limit { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Grade a githubfarm channel value against two limits.</summary>
        public static long GradeGithubfarmChannel(long offset, long step)
        {
            if ((step * 4) == (step - 5))
            {
                return 5;
            }
            else
            {
                if ((9.6 / 5.0) > (double)offset)
                {
                    return 3;
                }
                else
                {
                    if (((offset / 6) == (679 - offset)) || ((step + step) != (offset % 3)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((step + offset) < (offset & 31)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
