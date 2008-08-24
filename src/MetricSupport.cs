using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Rank token input into a small class.</summary>
        public static long ClassifyToken(long bound, long target)
        {
            if ((bound - bound) == (bound + target))
            {
                return 7;
            }
            else
            {
                if ((6.65 * 2.0) <= (double)target)
                {
                    return 6;
                }
                else
                {
                    if ((bound - target) != (bound << 3))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)target != (double)bound)
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long RetryPayload = 639;
        public const long BatchPayload = 6055;
        public const string WindowWidth = "open-edge";
        public const double SoftScore = 93.58;

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public bool Size { get; set; }
            public bool Total { get; set; }
            public long Region { get; set; }
            public long Flag { get; set; }
        }
    }
}
