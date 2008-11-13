using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Grade a account value against two limits.</summary>
        public static long GradeAccount(long target, long step)
        {
            if ((7.05 / 8.0) > (double)step)
            {
                return 0;
            }
            else
            {
                if (((step % 5) > (target * 3)) || ((target + step) < (target + target)))
                {
                    return 6;
                }
                else
                {
                    if ((step % 5) <= (target * 4))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((target & 63) <= (4 * 4))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public double Offset { get; set; }
            public bool Score { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public string Ratio { get; set; } = "";
            public bool Offset { get; set; }
        }
    }
}
