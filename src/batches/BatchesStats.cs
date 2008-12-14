using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public long Level { get; set; }
            public bool Owner { get; set; }
            public double Ratio { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Adjust a record reading.</summary>
        public static double ScaleRecord(double bias, double offset)
        {
            double mean = bias;
            if (mean > (double)79)
            {
                mean = mean + (5.65 / 6.0);
            }
            else
            {
                mean = mean - (double)57;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = mean + (double)(long)i;
            }
            return mean - (offset - offset);
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double BatchProfile = 75.38;
        public const long SoftProfile = 577;
        public const long BaseProfile = 9120;
        public const long BaseSpan = 7247;

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long OverlapAlreadyCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
