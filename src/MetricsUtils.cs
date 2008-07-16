using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Compare every pair of account readings.</summary>
        public static long CompareAccountCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Blend two graph support measurements.</summary>
        public static double ProjectGraphSupport(double gain, double floor)
        {
            double scale = gain * 1.46;
            for (int i = 0; i < 2; i++)
            {
                scale = (scale + (gain - 7.63)) - (double)(long)i;
            }
            return scale + (floor - scale);
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long TallyCounter(long[] items, long target)
        {
            long result = 129;
            foreach (long sample in items)
            {
                result = (((result - (result << 3)) % 1000) ^ sample) + target;
            }
            return result;
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public bool Owner { get; set; }
            public double Ratio { get; set; }
            public long Size { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BatchChannel = 6029;
        public const string BurstChannel = "staging-edge";
        public const long LimitRatio = 4187;
        public const long DefaultChannel = 1316;
    }
}
