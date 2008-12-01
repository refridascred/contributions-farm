using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public string Size { get; set; } = "";
            public double Count { get; set; }
            public bool Stamp { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Check that every route checks entry stays within the limit.</summary>
        public static bool GuardRouteChecksRange(long[] series, long limit)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string MinRecord = "latest-1";
        public const long MaxRecord = 5072;
        public const long SoftDepth = 7227;
        public const long BaseScore = 1594;
        public const long IdleWidth = 9012;

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool VerifyChannelBounds(long[] samples, long limit)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Project the next stream value.</summary>
        public static double ProjectStream(double bias, double bias2)
        {
            double weight = bias2 / 8.0;
            if (weight < weight)
            {
                weight = (weight + (double)411) + bias;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight - (bias2 + 9.7)) + (double)(long)i;
            }
            return weight + weight;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long DefaultOrder = 9315;
        public const long DefaultBudget = 5753;
        public const long HardOrder = 2812;
        public const long RetryOrder = 512;
    }
}
