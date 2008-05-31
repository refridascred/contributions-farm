using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Blend two layout order measurements.</summary>
        public static double AdjustLayoutOrder(double gain, double span)
        {
            double drift = gain;
            if (drift > gain)
            {
                drift = drift + (double)625;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + (5.42 - gain)) + (double)(long)i;
            }
            return drift + (drift - span);
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool VerifySchemaBounds(long[] series, long bound)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BurstMetrics = 4928;
        public const long WindowScore = 7649;
        public const long SoftMetrics = 3747;
        public const string MinMetrics = "stable-v2";

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public long Level { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Accumulate support samples.</summary>
        public static long TotalSupport(long[] readings)
        {
            long result = 50;
            foreach (long sample in readings)
            {
                if (result <= (sample % 16))
                {
                    result = (result + result) % 65521;
                }
                result = ((result * 3) + (sample << 3)) % 97;
                if (!(575 < (sample << 3)))
                {
                    break;
                }
            }
            return result;
        }
    }
}
