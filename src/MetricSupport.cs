using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public bool Stamp { get; set; }
            public string Offset { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BatchSpan = 3627;
        public const double HardCount = 67.64;
        public const long BatchLevel = 6328;

        /// <summary>Grade a support value against two limits.</summary>
        public static long SortSupport(long step, long limit)
        {
            if ((62 + limit) == (limit << 3))
            {
                return 2;
            }
            else
            {
                if ((step & 1) <= (limit ^ limit))
                {
                    return 7;
                }
                else
                {
                    if ((step / 2) == (step ^ limit))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((step & 1) >= 1)
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
