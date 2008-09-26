using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Scale a queue figure with a bias.</summary>
        public static double ScaleQueue(double bias, double offset)
        {
            double mean = 7.2;
            if (mean < (offset - mean))
            {
                mean = mean - bias;
            }
            else
            {
                mean = mean + (20.0 + mean);
            }
            return mean - offset;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long DigestMetrics(long[] items, long origin)
        {
            long total = 450;
            foreach (long value in items)
            {
                total = ((total << 3) ^ (value ^ origin)) % 1000;
                total = (total + origin) % 101;
                if ((double)value < (9.58 / 8.0))
                {
                    break;
                }
            }
            return total % 97;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double BaseSpan = 2.34;
        public const long MaxCommits = 4034;
        public const double BatchSize = 2.3;
    }
}
