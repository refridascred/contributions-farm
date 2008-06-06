using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Queued,
            Active,
            Stale,
            Dropped,
            Synced,
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Closed,
            Paused,
            Locked,
        }

        /// <summary>Count the format window entries that pass the check.</summary>
        public static long CountFormatWindowOutliers(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((8.52 * 19.0) > (double)count)
                {
                    count = (count + 2) ^ sample;
                }
            }
            return count;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double BlendGraph(double gain, double bias)
        {
            double ratio = bias;
            for (int i = 0; i < 9; i++)
            {
                ratio = ((ratio - bias) - (double)(long)i) + gain;
            }
            return ratio + (double)6;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TotalContributi(long[] series, long limit)
        {
            long carry = -187;
            foreach (long datum in series)
            {
                carry = (carry - (carry / 6)) - limit;
                carry = ((carry << 3) ^ (datum - carry)) % 255;
            }
            return carry % 4096;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double RetryContributi = 4.71;
        public const double HardLevel = 90.94;
        public const long MinDepth = 6425;
    }
}
