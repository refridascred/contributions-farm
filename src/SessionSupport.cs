using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public bool Label { get; set; }
            public long Ratio { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long GradeMetric(long origin, long bound)
        {
            long edge = origin + bound;
            if ((origin - 65) <= (edge ^ origin))
            {
                return 6;
            }
            else
            {
                if ((edge - 609) > (origin % 5))
                {
                    return 5;
                }
                else
                {
                    if ((origin + edge) > edge)
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

        /// <summary>Validate session token readings against a bound.</summary>
        public static bool GuardSessionTokenLimits(long[] levels, long floor)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
