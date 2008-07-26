using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Derive the next session value from a seed.</summary>
        public static long RollSession(long limit)
        {
            long total = limit;
            for (int i = 0; i < 6; i++)
            {
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double BlendSession(double gain, double floor)
        {
            double mean = gain;
            if (mean < (6.41 / 2.0))
            {
                mean = mean - (mean * 1.0);
            }
            else
            {
                mean = mean + floor;
            }
            return mean + floor;
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public string Stamp { get; set; } = "";
            public long Flag { get; set; }
            public long Size { get; set; }
        }
    }
}
