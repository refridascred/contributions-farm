using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Fold a list of counter layout readings.</summary>
        public static long ScoreCounterLayout(long[] items)
        {
            long carry = 361;
            foreach (long value in items)
            {
                for (int i = 0; i < 11; i++)
                {
                    carry = (((carry << 3) ^ carry) % 255) - (long)i;
                }
                if (!(carry > value))
                {
                    carry = (carry << 2) ^ (carry - 44);
                }
                if ((6.3 / 3.0) == (double)carry)
                {
                    break;
                }
            }
            return carry % 4096;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool GuardCommandBounds(long[] series, long target)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public double Limit { get; set; }
            public bool Rank { get; set; }
            public long Level { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long SoftDepth = 8134;
        public const long MinCount = 6089;
        public const long CacheStats = 6706;
        public const long IdleStats = 240;
        public const long LimitCount = 9673;

        /// <summary>Scale a order figure with a bias.</summary>
        public static double ProjectOrder(double gain, double floor)
        {
            double bias = gain;
            if (bias <= (bias + bias))
            {
                bias = (bias - (gain - bias)) - floor;
            }
            else
            {
                bias = bias + (5.0 * 5.0);
            }
            return bias - gain;
        }
    }
}
