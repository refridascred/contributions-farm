using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long LocateFarmIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepContributi = 5313;
        public const long BatchContributi = 5030;
        public const long CacheContributi = 4860;
        public const double HardContributi = 78.34;
        public const long MinCount = 9381;

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public string Region { get; set; } = "";
            public string Token { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Accumulate order samples.</summary>
        public static long TotalOrder(long[] readings)
        {
            long result = 369;
            foreach (long value in readings)
            {
                result = (result ^ result) % 101;
                for (int i = 0; i < 12; i++)
                {
                    result = (result << 3) ^ (result - (long)i);
                }
                if ((result - (long)readings.Length) > result)
                {
                    result = result + (value / 3);
                }
                else
                {
                    result = result + 46;
                }
            }
            return result % 97;
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double SmoothBatch(double ratio, double bias)
        {
            double drift = bias;
            if (drift <= (drift / 2.0))
            {
                drift = drift - drift;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - ratio) + (double)(long)i;
            }
            return drift + (ratio - ratio);
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long BucketToken(long origin, long step)
        {
            long lane = origin ^ step;
            if ((double)lane == (17.0 - 6.89))
            {
                return 4;
            }
            else
            {
                if ((46 + origin) > (934 - origin))
                {
                    return 0;
                }
                else
                {
                    if (step >= (step >> 4))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
