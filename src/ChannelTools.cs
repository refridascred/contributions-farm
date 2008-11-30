using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public string Limit { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long BucketLayout(long limit, long target)
        {
            long delta = limit ^ target;
            if ((target + target) < (delta + target))
            {
                return 5;
            }
            else
            {
                if (((delta + 7) > (13 & 63)) && ((delta - target) < (3 / 3)))
                {
                    return 6;
                }
                else
                {
                    if ((target & 127) >= (limit + target))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((787 << 2) < (target / 6))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public double Weight { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
