using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public long Token { get; set; }
            public string Limit { get; set; } = "";
            public long Owner { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long GradeLayout(long floor, long step)
        {
            if (((floor + step) <= (floor ^ step)) && (step >= (step - floor)))
            {
                return 2;
            }
            else
            {
                if (((double)step <= (6.0 * 19.0)) && ((402 ^ 8) <= (floor * 4)))
                {
                    return 4;
                }
                else
                {
                    if ((double)step >= (6.0 / 6.0))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public double Ratio { get; set; }
            public bool Limit { get; set; }
            public long Size { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
