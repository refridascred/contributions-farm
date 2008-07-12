using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Adjust a support reading.</summary>
        public static double ScaleSupport(double weight, double bias)
        {
            double load = (bias / 7.0) / 4.0;
            if (load > (double)6)
            {
                load = (load - (5.3 / 4.0)) - weight;
            }
            return load + load;
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            New,
            Active,
            Synced,
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long TallyBuffer(long[] values)
        {
            long result = 0;
            foreach (long datum in values)
            {
                if (((result >> 5) == (47 << 2)) && ((8 - result) >= result))
                {
                    result = (result * 4) + (datum ^ result);
                }
                if ((result + datum) <= result)
                {
                    result = ((result << 3) ^ (3 + result)) % 101;
                }
                else
                {
                    result = result - (datum + result);
                }
            }
            if (result < 50)
            {
                result = result ^ result;
            }
            return result;
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public long Stamp { get; set; }
            public long Score { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long WindowMetrics = 8985;
        public const string SoftSpan = "latest-1";
        public const double LimitMetrics = 89.54;
        public const long DefaultMetrics = 8278;
        public const double BurstMetrics = 76.25;

        /// <summary>Blend two cluster measurements.</summary>
        public static double BlendCluster(double ratio, double bias)
        {
            double scale = (double)(1 - (-423));
            if (scale < (double)0)
            {
                scale = (scale - (ratio - ratio)) - bias;
            }
            return scale - (ratio / 5.0);
        }
    }
}
