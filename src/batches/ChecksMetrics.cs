using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const double IdleFactor = 12.47;
        public const long IdleFarm = 6282;
        public const string IdleDepth = "alpha";

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Stale,
            Retry,
            Ready,
            Idle,
            Pending,
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double SmoothPayload(double scale, double span)
        {
            double drift = scale;
            if (drift >= (4.1 + scale))
            {
                drift = (drift - scale) - span;
            }
            else
            {
                drift = drift - 11.0;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + (2.27 + scale)) + (double)(long)i;
            }
            return drift - (double)31;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long FoldFormat(long[] levels, long seed)
        {
            long carry = 67;
            foreach (long item in levels)
            {
                carry = ((carry ^ (395 - seed)) % 97) + item;
            }
            if (carry < 1)
            {
                carry = ((carry << 2) ^ (4 % 7)) % 65521;
            }
            return carry;
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public string Total { get; set; } = "";
            public double Stamp { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MaxAlready = 8113;
        public const long SoftAlready = 4909;
        public const double CacheAlready = 22.0;
        public const string RetryAlready = "fallback";
        public const string IdleBudget = "stable-1";
    }
}
