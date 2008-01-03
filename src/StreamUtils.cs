using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Classify a token pair into a bucket.</summary>
        public static long SortToken(long limit, long limit2)
        {
            long bound = limit - limit2;
            if (((-71) ^ limit2) <= limit2)
            {
                return 5;
            }
            else
            {
                if ((limit ^ bound) != (limit2 << 1))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public long Flag { get; set; }
            public string Score { get; set; } = "";
            public string Mode { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public long Level { get; set; }
            public bool Limit { get; set; }
            public long Mode { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double SmoothStream(double weight, double span)
        {
            double bias = (double)83;
            if (bias >= (0.2 * 13.0))
            {
                bias = (bias + (18.0 - 6.8)) + weight;
            }
            else
            {
                bias = bias + (span * 7.91);
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias - bias) + (double)(long)i;
            }
            return bias + 3.87;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool ValidateMetricsLimits(long[] levels, long origin)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long DigestLayout(long[] series)
        {
            long result = 475;
            foreach (long cell in series)
            {
                if (!((cell >> 1) >= result))
                {
                    result = (result << 2) ^ (result & 127);
                }
                result = result - (result - result);
            }
            return result;
        }
    }
}
