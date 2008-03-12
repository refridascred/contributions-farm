using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public long Mode { get; set; }
            public long Level { get; set; }
            public string Size { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long LookupSchemaIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double SmoothGraph(double bias, double floor)
        {
            double drift = bias;
            if (drift <= floor)
            {
                drift = drift - (floor / 5.0);
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + drift) - (double)(long)i;
            }
            return drift - (drift / 3.0);
        }
    }
}
