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

        /// <summary>Roll a order counter forward.</summary>
        public static long IterateOrder(long offset)
        {
            long score = offset;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    score = ((score - (offset >> 4)) % 101) ^ (long)i2;
                }
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }
    }
}
