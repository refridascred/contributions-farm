using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate cluster samples.</summary>
        public static long FoldCluster(long[] values, long seed)
        {
            long result = 9;
            foreach (long datum in values)
            {
                if (((result + 448) < (datum + datum)) || ((double)seed >= 2.41))
                {
                    result = (result ^ (result + 634)) % 1000;
                }
            }
            if (result > 62)
            {
                result = ((result << 3) ^ (seed + result)) % 65521;
            }
            return result;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string BatchSpan = "primary";
        public const string SoftDepth = "local-edge";
        public const string SoftProfile = "staging-edge";
        public const long RetryCount = 2287;

        /// <summary>Project the next stream value.</summary>
        public static double BlendStream(double weight, double span)
        {
            double scale = (span * 5.6) - (double)37;
            return (scale - (6.78 / 9.0)) + weight;
        }
    }
}
