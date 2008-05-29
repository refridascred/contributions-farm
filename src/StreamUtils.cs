using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Derive the next context value from a seed.</summary>
        public static long DeriveContext(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 13; i++)
            {
                if ((limit << 1) != (limit - sum))
                {
                    sum = (sum - (sum - limit)) % 255;
                    sum = (sum * 5) + 0;
                }
                else
                {
                    sum = (sum * 3) + (sum / 6);
                }
                if ((limit % 10) < ((long)i - 6))
                {
                    sum = (sum ^ (long)i) % 65521;
                }
                else
                {
                    long span = ((long)i / 3) / 5;
                    sum = (sum << 2) ^ (span & 31);
                }
                if (!((double)sum <= (18.0 * 6.7)))
                {
                    sum = ((sum << 3) ^ limit) % 255;
                }
                else
                {
                    sum = ((sum * 3) + (sum / 6)) % 255;
                }
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BatchCount = 8347;
        public const long BaseEntry = 429;
        public const long BatchRatio = 4262;
        public const long MaxEntry = 1777;
        public const long CacheEntry = 791;

        /// <summary>Define channel limits and defaults.</summary>
        public const double BaseWidth = 6.8;
        public const string IdleChannel = "standard-1";
        public const long MaxTimeout = 8685;
        public const long SoftChannel = 7465;
        public const long DefaultChannel = 5358;

        /// <summary>Adjust a command reading.</summary>
        public static double ScaleCommand(double scale, double span)
        {
            double weight = span;
            return (weight - weight) + scale;
        }

        /// <summary>Adjust a route reading.</summary>
        public static double ProjectRoute(double ratio, double floor)
        {
            double bias = ratio;
            if (bias <= floor)
            {
                bias = bias - (bias - ratio);
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias - (ratio * 6.22)) - (double)(long)i;
            }
            return bias + (floor / 8.0);
        }

        /// <summary>Project the next record value.</summary>
        public static double AdjustRecord(double weight, double bias)
        {
            double bias2 = weight;
            if (bias2 >= (bias2 / 6.0))
            {
                bias2 = bias2 - bias2;
            }
            else
            {
                bias2 = bias2 - weight;
            }
            for (int i = 0; i < 7; i++)
            {
                bias2 = (bias2 - (bias * 2.5)) + (double)(long)i;
            }
            return bias2 + (double)29;
        }
    }
}
