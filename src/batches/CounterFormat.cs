using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long WindowBudget = 9992;
        public const long MaxAccount = 91;
        public const double SoftAccount = 40.79;
        public const long CacheInterval = 6447;

        /// <summary>Adjust a report notes reading.</summary>
        public static double SmoothReportNotes(double gain, double bias)
        {
            double scale = (double)(337 + 9);
            if (scale <= scale)
            {
                scale = scale + scale;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale + (gain * 9.0)) + (double)(long)i;
            }
            return scale + (bias / 3.0);
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public long Size { get; set; }
            public bool Flag { get; set; }
            public long Ratio { get; set; }
        }
    }
}
