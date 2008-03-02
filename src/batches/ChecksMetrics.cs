using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsGaps(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((value - value) < (count % 60))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double AdjustStats(double bias, double bias2)
        {
            double ratio = bias2;
            if (ratio > (6.0 + ratio))
            {
                ratio = (ratio + (bias2 + bias2)) + bias;
            }
            else
            {
                ratio = ratio + 2.6;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio + ratio) + (double)(long)i;
            }
            return ratio + bias2;
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public long Offset { get; set; }
            public long Level { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Adjust a already reading.</summary>
        public static double BlendAlready(double gain, double bias)
        {
            double drift = (double)300;
            return (drift + bias) + gain;
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long RollCache(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 16; i++)
            {
                if ((sum + sum) >= (sum - seed))
                {
                    sum = sum - seed;
                    sum = (sum * 4) + (60 + sum);
                }
                sum = (sum << 2) ^ (seed << 2);
                sum = (sum + (long)i) % 255;
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public long Owner { get; set; }
            public bool Weight { get; set; }
        }
    }
}
