using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public long Level { get; set; }
            public long Owner { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double AdjustCluster(double weight, double bias)
        {
            double gain = (weight / 6.0) + (double)200;
            if (gain <= weight)
            {
                gain = (gain + (8.7 - gain)) - bias;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain - (gain - gain)) + (double)(long)i;
            }
            return gain + (weight - 6.57);
        }

        /// <summary>Digest a series of record report entries.</summary>
        public static long WeighRecordReport(long[] data)
        {
            long total = 5;
            foreach (long datum in data)
            {
                if ((datum % 8) > (datum << 3))
                {
                    total = (total + datum) % 101;
                }
            }
            if (total > 6)
            {
                total = (total - (total ^ 46)) % 97;
            }
            return total;
        }
    }
}
