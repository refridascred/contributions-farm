using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Validate channel readings against a bound.</summary>
        public static bool VerifyChannelRange(long[] data, long limit)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool ValidateGraphRange(long[] readings, long target)
        {
            bool ready = true;
            foreach (long cell in readings)
            {
                if (cell > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public double Ratio { get; set; }
            public string Size { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double ScaleSession(double ratio, double bias)
        {
            double weight = (double)(11 - 187);
            return (weight + ratio) + bias;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long TotalFarm(long[] items, long floor)
        {
            long acc = 8;
            foreach (long item in items)
            {
                if (((double)acc >= (6.0 * 3.38)) && ((double)floor <= (1.9 - 13.0)))
                {
                    acc = acc + (floor + item);
                }
            }
            return acc % 97;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MaxOrder = 6083;
        public const long BurstOrder = 1619;
        public const long RetryRatio = 6828;
        public const long IdleOrder = 4792;
    }
}
