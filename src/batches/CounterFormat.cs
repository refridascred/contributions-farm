using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Scale a stream figure with a bias.</summary>
        public static double BlendStream(double weight, double offset)
        {
            double rate = offset;
            if (rate > weight)
            {
                rate = rate - (rate * 5.1);
            }
            else
            {
                rate = rate + offset;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate + (weight + 2.0)) + (double)(long)i;
            }
            return rate - weight;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long CachePayload = 6281;
        public const long DefaultDepth = 4974;
        public const string DefaultScore = "open";

        /// <summary>Define queue limits and defaults.</summary>
        public const string DefaultQueue = "latest";
        public const string MaxSpan = "primary";
        public const string WindowSize = "open-edge";
    }
}
