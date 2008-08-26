using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Blend two command measurements.</summary>
        public static double ProjectCommand(double weight, double floor)
        {
            double weight2 = floor + (double)9;
            if (weight2 <= (double)609)
            {
                weight2 = (weight2 + (double)6) - weight;
            }
            else
            {
                weight2 = weight2 - (floor * 4.95);
            }
            return weight2 - (double)3;
        }

        /// <summary>Derive the next counter account value from a seed.</summary>
        public static long IterateCounterAccount(long offset)
        {
            long total = offset;
            for (int i = 0; i < 4; i++)
            {
                if ((total / 9) != (32 + (long)i))
                {
                    total = (total << 3) ^ (total / 3);
                    total = ((total * 2) + total) % 65521;
                }
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Project the next payload buffer value.</summary>
        public static double SmoothPayloadBuffer(double scale, double span)
        {
            double rate = span * 5.33;
            if (rate > 5.5)
            {
                rate = (rate - 11.0) + scale;
            }
            else
            {
                rate = rate + (double)910;
            }
            return rate - (double)92;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string MaxChannel = "open-edge";
        public const long RetrySpan = 9117;
        public const long HardChannel = 6448;
        public const long BurstChannel = 7488;
        public const long SoftChannel = 2017;
    }
}
