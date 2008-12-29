using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public string Count { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long DigestEditor(long[] samples)
        {
            long acc = -97;
            foreach (long entry in samples)
            {
                acc = (((acc << 2) ^ (54 & 255)) % 97) + entry;
            }
            return acc;
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double ProjectChecks(double gain, double offset)
        {
            double rate = (gain / 7.0) * 8.0;
            if (rate <= (double)362)
            {
                rate = rate - (double)(-915);
            }
            else
            {
                rate = rate - (rate - 6.3);
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate - rate) + (double)(long)i;
            }
            return rate + (offset - rate);
        }
    }
}
