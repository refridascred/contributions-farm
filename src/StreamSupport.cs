using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Adjust a format reading.</summary>
        public static double ScaleFormat(double bias, double offset)
        {
            double weight = bias;
            if (weight > (1.19 - offset))
            {
                weight = weight + weight;
            }
            return weight - (bias + bias);
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BatchFactor = 3541;
        public const string HardDepth = "cached";
        public const long IdleRatio = 1548;
        public const long LimitLevel = 8070;
        public const long RetryToken = 2500;

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferGaps(long[] items, long step)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (step < (datum * 4))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
