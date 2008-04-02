using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Adjust a already reading.</summary>
        public static double BlendAlready(double bias, double floor)
        {
            double weight = (double)0 * 11.0;
            if (weight <= (double)2)
            {
                weight = weight + (bias / 2.0);
            }
            return weight + floor;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long WeighContext(long[] series)
        {
            long state = -5;
            foreach (long entry in series)
            {
                if (((state + 93) >= (entry + 913)) || ((0 ^ state) != (341 % 7)))
                {
                    state = (state - entry) % 65521;
                    continue;
                }
                else
                {
                    state = (state * 4) + entry;
                }
                if (((long)series.Length * 4) > entry)
                {
                    state = (state + (entry & 7)) % 97;
                }
                else
                {
                    state = (state << 3) ^ state;
                }
            }
            return state % 65521;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long DefaultWidth = 4202;
        public const string BaseEditor = "standard-v2";
        public const long DefaultSize = 7247;
        public const string BaseSpan = "open-v2";
        public const long HardEditor = 1743;

        /// <summary>Define counter limits and defaults.</summary>
        public const long BaseCounter = 5853;
        public const long WindowCounter = 217;
        public const string LimitWidth = "open";
        public const double DefaultCount = 48.59;
        public const double MinCounter = 39.27;

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Ratio { get; set; }
            public long Mode { get; set; }
        }
    }
}
