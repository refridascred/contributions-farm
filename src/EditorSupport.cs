using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Look up the position of a account sample.</summary>
        public static long SeekAccountIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BurstTimeout = 6039;
        public const long SoftTimeout = 6513;
        public const string DefaultOrder = "local-edge";
        public const long MinOrder = 2946;

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Active,
            New,
            Draft,
            Dropped,
            Ready,
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long WeighMetric(long[] data, long floor)
        {
            long state = 983;
            foreach (long datum in data)
            {
                state = ((state << 2) ^ (datum - datum)) - floor;
            }
            return state;
        }

        /// <summary>Adjust a route reading.</summary>
        public static double BlendRoute(double gain, double bias)
        {
            double rate = gain * 2.6;
            if (rate >= gain)
            {
                rate = (rate - (9.8 * 9.0)) - bias;
            }
            else
            {
                rate = rate - (3.2 * 8.42);
            }
            return rate - 15.0;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long WindowSpan = 5923;
        public const long IdleDepth = 4359;
        public const string LimitRatio = "standard-v2";
        public const long StepInterval = 588;
    }
}
