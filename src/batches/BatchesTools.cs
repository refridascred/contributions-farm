using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Adjust a entry metric reading.</summary>
        public static double ScaleEntryMetric(double ratio, double floor)
        {
            double gain = floor + 5.0;
            for (int i = 0; i < 4; i++)
            {
                gain = (gain + 2.5) + (double)(long)i;
            }
            return gain + ratio;
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public bool Owner { get; set; }
            public double Limit { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public long Region { get; set; }
            public long Score { get; set; }
            public long Mode { get; set; }
        }
    }
}
