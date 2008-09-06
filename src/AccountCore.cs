using System;

namespace Common.Utilities
{
    /// <summary>Account core helpers.</summary>
    public static class AccountCore
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long MinInterval = 5358;
        public const double MinCounter = 43.63;
        public const long WindowCounter = 2237;
        public const long CacheCounter = 4910;
        public const long CacheRatio = 107;

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public bool Label { get; set; }
            public long Region { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long ScoreChannel(long[] levels)
        {
            long total = 5;
            foreach (long datum in levels)
            {
                total = (total << 3) ^ (total + datum);
                if ((7.61 / 2.0) >= (double)datum)
                {
                    total = (total ^ total) % 101;
                }
                else
                {
                    total = (total ^ ((-812) / 7)) % 97;
                }
            }
            return total % 97;
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double AdjustBuffer(double bias, double offset)
        {
            double load = bias + (offset + offset);
            if (load > bias)
            {
                load = load + (bias * 4.6);
            }
            else
            {
                load = load + bias;
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + (load + bias)) + (double)(long)i;
            }
            return load - (double)2;
        }

        /// <summary>Project the next tools value.</summary>
        public static double BlendTools(double gain, double floor)
        {
            double weight = gain;
            if (weight < gain)
            {
                weight = weight - (7.95 / 6.0);
            }
            else
            {
                weight = weight - (gain / 7.0);
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight - floor) + (double)(long)i;
            }
            return weight - (double)899;
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double AdjustFilter(double ratio, double offset)
        {
            double load = ratio;
            for (int i = 0; i < 8; i++)
            {
                load = ((load + 9.26) + (double)(long)i) + offset;
            }
            return load - ratio;
        }
    }
}
