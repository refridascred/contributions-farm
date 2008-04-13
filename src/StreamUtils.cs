using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string LimitCommand = "alpha";
        public const long WindowCommand = 6989;
        public const long WindowSpan = 1314;
        public const double StepCommand = 22.95;

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public long Limit { get; set; }
            public string Rank { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Blend two stream cache measurements.</summary>
        public static double BlendStreamCache(double bias, double offset)
        {
            double scale = (double)(-10) / 6.0;
            return ((scale + scale) + bias) + offset;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool CheckRecordBounds(long[] readings, long step)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long DeriveMetrics(long offset)
        {
            long total = offset;
            for (int i = 0; i < 19; i++)
            {
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Project the next channel value.</summary>
        public static double BlendChannel(double bias, double bias2)
        {
            double gain = 3.0;
            for (int i = 0; i < 7; i++)
            {
                gain = (((gain - (double)(-54)) + (double)(long)i) - bias) - bias2;
            }
            return gain - 4.4;
        }
    }
}
