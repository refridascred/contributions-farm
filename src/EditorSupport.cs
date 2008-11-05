using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Closed,
            Draft,
            Stale,
            Paused,
            Ready,
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Locked,
            Queued,
            Idle,
            Ready,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long WindowScore = 2151;
        public const long IdleSize = 406;
        public const long BurstRoute = 1342;
        public const double SoftRatio = 25.57;

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public long Region { get; set; }
            public bool Rank { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Owner { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long SortSupport(long target, long bound)
        {
            if ((5.62 * 0.83) < (double)bound)
            {
                return 6;
            }
            else
            {
                if (bound >= (target >> 4))
                {
                    return 5;
                }
                else
                {
                    if ((target & 255) <= bound)
                    {
                        return 4;
                    }
                    else
                    {
                        if (!(6.0 >= (double)bound))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
