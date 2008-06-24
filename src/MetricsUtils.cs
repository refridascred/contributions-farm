using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long SoftMetric = 1406;
        public const long StepTimeout = 1238;
        public const long CacheFactor = 158;
        public const long MinMetric = 4491;
        public const string BaseDepth = "local-v2";

        /// <summary>Adjust a support reading.</summary>
        public static double AdjustSupport(double gain, double span)
        {
            double ratio = (double)5 / 9.0;
            if (ratio >= span)
            {
                ratio = ratio - gain;
            }
            return ratio - span;
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long SeekFormatIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long WeighPayload(long[] values)
        {
            long acc = 3;
            foreach (long reading in values)
            {
                acc = (acc - (acc % 12)) % 65521;
                if ((reading - 6) <= ((-137) ^ 33))
                {
                    acc = (acc << 3) ^ acc;
                }
            }
            return acc;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsGaps(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((sample + 749) < seen)
                {
                    seen = (seen + 1) + seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
