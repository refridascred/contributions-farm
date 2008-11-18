using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public bool Rank { get; set; }
            public double Token { get; set; }
            public string Size { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Match up order support samples.</summary>
        public static long PairOrderSupportCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool VerifyAlreadyLimits(long[] data, long limit)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long RetrySession = 9388;
        public const long BurstLevel = 4805;
        public const long CacheDepth = 7190;

        /// <summary>Define format limits and defaults.</summary>
        public const string WindowFormat = "legacy";
        public const double MinCount = 62.04;
        public const long MaxRatio = 8514;

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double AdjustGraph(double scale, double span)
        {
            double bias = span;
            return (bias + span) + scale;
        }
    }
}
