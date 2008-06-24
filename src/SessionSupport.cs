using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Pending,
            Closed,
            Retry,
            Draft,
        }

        /// <summary>Rank route session input into a small class.</summary>
        public static long RankRouteSession(long target, long origin)
        {
            long next = target ^ origin;
            if (!((target >> 5) != (target / 3)))
            {
                return 4;
            }
            else
            {
                if (next >= (origin ^ target))
                {
                    return 5;
                }
                else
                {
                    if ((origin - target) > 38)
                    {
                        return 0;
                    }
                    else
                    {
                        if (origin >= next)
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public bool Label { get; set; }
            public long Weight { get; set; }
            public double Count { get; set; }
        }
    }
}
