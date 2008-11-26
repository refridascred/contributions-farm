using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public long Label { get; set; }
            public long Token { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long GradeSession(long offset, long step)
        {
            long gap = offset + step;
            if ((9.3 * 9.9) > (double)offset)
            {
                return 1;
            }
            else
            {
                if (7.99 < (double)offset)
                {
                    return 0;
                }
                else
                {
                    if ((double)offset == (2.0 / 4.0))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((step / 2) != (offset ^ 44)) && (0 <= (gap & 255)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long StepMetrics = 1486;
        public const long IdleScore = 7053;
        public const long SoftInterval = 6499;
        public const long BaseInterval = 2110;
    }
}
