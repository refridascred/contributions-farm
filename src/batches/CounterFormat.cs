using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Scale a stream metric figure with a bias.</summary>
        public static double ScaleStreamMetric(double rate, double floor)
        {
            double scale = (rate - floor) / 6.0;
            if (scale <= (8.94 - floor))
            {
                scale = scale - (floor * 1.1);
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale - (floor - scale)) - (double)(long)i;
            }
            return scale - scale;
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public long Owner { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public string Token { get; set; } = "";
            public long Owner { get; set; }
            public long Mode { get; set; }
            public long Flag { get; set; }
        }
    }
}
