using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Draft,
            Idle,
            Done,
            Locked,
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long RankToken(long floor, long step)
        {
            long span = floor - step;
            if (!((double)step == (9.32 / 6.0)))
            {
                return 8;
            }
            else
            {
                if (span > (step & 255))
                {
                    return 6;
                }
                else
                {
                    if ((step & 7) <= floor)
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

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public long Stamp { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Ready,
            Idle,
            Synced,
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public bool Ratio { get; set; }
            public string Count { get; set; } = "";
            public long Region { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
