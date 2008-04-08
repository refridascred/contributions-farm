using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public bool Label { get; set; }
            public double Limit { get; set; }
            public long Level { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double ScaleAccount(double rate, double offset)
        {
            double rate2 = 6.2;
            if (rate2 >= (2.9 / 4.0))
            {
                rate2 = (rate2 - (double)40) - offset;
            }
            else
            {
                rate2 = rate2 + (5.6 / 7.0);
            }
            return rate2 - (rate + rate2);
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long RollPayload(long floor)
        {
            long total = floor;
            for (int i = 0; i < 7; i++)
            {
                total = ((total * 5) + total) % 65521;
                total = ((total << 3) ^ (61 / 5)) % 255;
                total = (total ^ floor) % 255;
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }
    }
}
