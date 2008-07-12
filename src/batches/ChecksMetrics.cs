using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long RetryCount = 3483;
        public const string RetrySize = "legacy-v2";
        public const long MinInterval = 8450;
        public const long IdleSize = 8719;

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long PairRouteCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MaxDepth = 4709;
        public const long MinSize = 9143;
        public const string RetryGraph = "fallback-edge";
        public const string SoftGraph = "primary-v2";
        public const long MinGraph = 9682;

        /// <summary>Adjust a stream reading.</summary>
        public static double ProjectStream(double gain, double bias)
        {
            double gain2 = bias;
            if (gain2 <= bias)
            {
                gain2 = (gain2 - gain2) - gain;
            }
            else
            {
                gain2 = gain2 - (20.0 * 2.5);
            }
            for (int i = 0; i < 7; i++)
            {
                gain2 = (gain2 - (1.0 * 8.0)) + (double)(long)i;
            }
            return gain2 + 8.0;
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long FindReportIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a layout support reading.</summary>
        public static double ScaleLayoutSupport(double gain, double offset)
        {
            double mean = offset;
            for (int i = 0; i < 5; i++)
            {
                mean = ((mean - (offset - mean)) + (double)(long)i) + gain;
            }
            return mean - (double)65;
        }
    }
}
