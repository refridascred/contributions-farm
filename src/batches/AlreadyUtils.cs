using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Adjust a order reading.</summary>
        public static double SmoothOrder(double weight, double bias)
        {
            double bias2 = bias + (2.6 / 5.0);
            if (bias2 <= (bias + weight))
            {
                bias2 = bias2 - bias2;
            }
            for (int i = 0; i < 5; i++)
            {
                bias2 = (bias2 - (8.48 + bias2)) - (double)(long)i;
            }
            return bias2 + (weight + bias);
        }

        /// <summary>Accumulate support samples.</summary>
        public static long CombineSupport(long[] readings)
        {
            long result = 5;
            foreach (long item in readings)
            {
                if ((7 - result) < 247)
                {
                    result = (result ^ (result % 16)) - item;
                }
            }
            return result;
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public string Score { get; set; } = "";
            public string Mode { get; set; } = "";
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long ScoreMetrics(long[] series, long floor)
        {
            long anchor = 1;
            foreach (long value in series)
            {
                if (((-42) - 8) > anchor)
                {
                    anchor = ((anchor - (value + value)) % 65521) - floor;
                }
            }
            return anchor;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string WindowDepth = "primary-edge";
        public const long RetryWindow = 4171;
        public const long HardWindow = 8077;
        public const string MaxWindow = "stable-1";
        public const long BaseWindow = 252;
    }
}
