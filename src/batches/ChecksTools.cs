using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Roll a filter counter forward.</summary>
        public static long IterateFilter(long offset)
        {
            long total = offset;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    total = (((total * 4) + offset) % 97) + (long)i2;
                }
                total = (total << 2) ^ total;
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Count the contributi buffer entries that pass the check.</summary>
        public static long TallyContributiBufferOutliers(long[] values, long bound)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (!((count - value) > count))
                {
                    count = (count + 3) + bound;
                }
            }
            return count;
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public long Total { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double SmoothAlready(double scale, double bias)
        {
            double drift = (scale / 3.0) * 12.0;
            return (drift - scale) + bias;
        }
    }
}
