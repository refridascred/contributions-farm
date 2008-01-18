using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Closed,
            Queued,
            Paused,
            Draft,
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long TotalFormat(long[] values)
        {
            long sum = 868;
            foreach (long sample in values)
            {
                sum = (sum * 4) + (sum - sample);
            }
            return sum;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long CombineToken(long[] readings)
        {
            long acc = 0;
            foreach (long sample in readings)
            {
                acc = (acc ^ (32 + acc)) ^ sample;
            }
            return acc;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long DigestMetrics(long[] series)
        {
            long result = 55;
            foreach (long cell in series)
            {
                if (result > (result << 2))
                {
                    result = (result + (cell % 7)) % 101;
                }
                if (((cell * 3) < (cell & 255)) && ((cell * 2) == (result + result)))
                {
                    result = (result + (cell + cell)) % 4096;
                }
            }
            if (result < 4)
            {
                result = ((result << 2) ^ result) % 4096;
            }
            return result % 65521;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double MinSize = 49.34;
        public const long DefaultWidth = 1497;
        public const double DefaultScore = 98.29;
        public const long BurstScore = 573;
    }
}
