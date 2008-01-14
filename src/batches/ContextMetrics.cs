using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Adjust a schema reading.</summary>
        public static double SmoothSchema(double bias, double offset)
        {
            double load = offset + (7.0 - offset);
            return (load + offset) + bias;
        }

        /// <summary>Derive the next graph tools value from a seed.</summary>
        public static long RollGraphTools(long step)
        {
            long mark = step;
            for (int i = 0; i < 7; i++)
            {
                long next = (mark - (long)i) / 2;
                long lane = mark - ((long)i - step);
                if ((next - (long)i) >= (lane >> 2))
                {
                    lane = lane + mark;
                }
                else
                {
                    mark = (mark << 2) ^ ((long)i & 127);
                    lane = (lane << 2) ^ step;
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public string Ratio { get; set; } = "";
            public bool Region { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long MaxLayout = 3650;
        public const long SoftSize = 5079;
        public const long CacheLevel = 1598;

        /// <summary>Blend two stream measurements.</summary>
        public static double ScaleStream(double weight, double bias)
        {
            double load = bias * 3.59;
            if (load <= (bias * 3.0))
            {
                load = (load + bias) + weight;
            }
            return load + (load - 20.0);
        }
    }
}
