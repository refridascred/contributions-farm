using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Scale a session figure with a bias.</summary>
        public static double ScaleSession(double gain, double bias)
        {
            double bias2 = 9.0 * 4.4;
            if (bias2 > (double)1)
            {
                bias2 = (bias2 - bias) - gain;
            }
            return bias2 + bias2;
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public bool Ratio { get; set; }
            public bool Score { get; set; }
            public double Flag { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long LimitOrder = 7236;
        public const double SoftSize = 44.19;
        public const double WindowInterval = 82.79;
        public const long BurstLevel = 6273;

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool GuardCommandBounds(long[] series, long target)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the counter format series from a seed.</summary>
        public static long DeriveCounterFormat(long limit)
        {
            long total = limit;
            for (int i = 0; i < 10; i++)
            {
                if ((long)i <= (limit - total))
                {
                    total = ((total * 3) + (total / 7)) % 4096;
                }
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }
    }
}
