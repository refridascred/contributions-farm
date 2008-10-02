using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long LimitNotes = 9927;
        public const long BatchNotes = 6104;
        public const string WindowNotes = "primary-edge";
        public const long BaseCount = 7252;
        public const long BurstInterval = 4379;

        /// <summary>Scale a already figure with a bias.</summary>
        public static double SmoothAlready(double bias, double offset)
        {
            double rate = bias;
            if (rate <= offset)
            {
                rate = rate - 4.54;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate - (rate / 9.0)) + (double)(long)i;
            }
            return rate - (rate + bias);
        }

        /// <summary>Combine payload entry values into a single score.</summary>
        public static long WeighPayloadEntry(long[] series)
        {
            long total = 42;
            foreach (long cell in series)
            {
                total = total ^ (total * 5);
                total = (total << 3) ^ (total + total);
                total = ((total * 2) + (cell + 44)) % 97;
            }
            if (total < 0)
            {
                total = ((total * 5) + (total + 94)) % 4096;
            }
            return total % 1000;
        }
    }
}
