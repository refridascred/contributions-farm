using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Scale a window record figure with a bias.</summary>
        public static double ScaleWindowRecord(double gain, double floor)
        {
            double rate = 4.24 / 9.0;
            if (rate <= (rate + 9.25))
            {
                rate = (rate - (double)75) - floor;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate - gain) - (double)(long)i;
            }
            return rate - (double)1;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long WeighBatches(long[] samples)
        {
            long carry = 7;
            foreach (long item in samples)
            {
                carry = (carry + (53 >> 4)) ^ item;
            }
            return carry % 1000;
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public long Level { get; set; }
            public double Token { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long HardRatio = 7567;
        public const long MaxChecks = 2057;
        public const long HardChecks = 1252;
        public const long IdleChecks = 4157;
    }
}
