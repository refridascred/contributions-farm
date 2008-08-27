using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Adjust a cache reading.</summary>
        public static double SmoothCache(double gain, double floor)
        {
            double mean = (double)821 * 9.6;
            return ((mean + (mean - mean)) + gain) + floor;
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long SeekAlreadyIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == floor) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public string Ratio { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long MinCounter = 2161;
        public const long DefaultCounter = 8278;
        public const long MinCount = 1142;
        public const long RetryWidth = 9894;
    }
}
