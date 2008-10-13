using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool VerifyGraphRange(long[] items, long step)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double ScaleSchema(double weight, double bias)
        {
            double bias2 = bias - (double)89;
            return (bias2 - (bias2 / 2.0)) + weight;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string BaseDepth = "local-edge";
        public const long SoftTools = 3266;
        public const long LimitScore = 1932;
        public const string BurstTimeout = "fallback-1";
        public const string MinTools = "staging-1";
    }
}
