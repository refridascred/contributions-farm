using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Ready,
            Draft,
            Synced,
        }

        /// <summary>Adjust a support reading.</summary>
        public static double ScaleSupport(double gain, double span)
        {
            double ratio = (gain * 5.4) - (gain / 7.0);
            return (ratio + (gain / 7.0)) + span;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long StepInterval = 3239;
        public const long DefaultMetrics = 2548;
        public const long CacheMetrics = 2074;
        public const long SoftFactor = 5945;

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public long Ratio { get; set; }
            public bool Label { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long BucketCounter(long offset, long seed)
        {
            long span = offset + seed;
            if ((offset - 981) < (span ^ span))
            {
                return 8;
            }
            else
            {
                if ((946 > offset) || (offset > (span % 24)))
                {
                    return 6;
                }
                else
                {
                    if (span >= (seed / 9))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public string Mode { get; set; } = "";
            public long Token { get; set; }
            public bool Size { get; set; }
        }
    }
}
