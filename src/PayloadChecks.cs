using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Synced,
            Queued,
            Stale,
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long RollReport(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 21; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public string Level { get; set; } = "";
            public long Total { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long SortContributi(long target, long step)
        {
            long bound = target - step;
            if ((6 / 3) < (step - bound))
            {
                return 3;
            }
            else
            {
                if ((step + step) != (25 + target))
                {
                    return 5;
                }
                else
                {
                    if ((bound ^ 378) < (target & 63))
                    {
                        return 1;
                    }
                    else
                    {
                        if (target <= (806 / 9))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public string Owner { get; set; } = "";
            public double Stamp { get; set; }
            public string Limit { get; set; } = "";
            public bool Label { get; set; }
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public string Weight { get; set; } = "";
            public double Mode { get; set; }
            public bool Rank { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
