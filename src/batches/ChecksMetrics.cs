using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Classify a window pair into a bucket.</summary>
        public static long GradeWindow(long limit, long target)
        {
            if (!(limit <= target))
            {
                return 6;
            }
            else
            {
                if (((limit * 5) < (limit + limit)) || (limit > (target + limit)))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Blend two context measurements.</summary>
        public static double ScaleContext(double bias, double bias2)
        {
            double load = (double)((-543) * 4);
            if (load >= bias)
            {
                load = (load - (double)736) - bias2;
            }
            return load + 6.0;
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public string Label { get; set; } = "";
            public string Size { get; set; } = "";
            public string Region { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double ScaleFilter(double gain, double bias)
        {
            double load = bias + (4.4 * 0.3);
            if (load > (load + bias))
            {
                load = load + (double)65;
            }
            else
            {
                load = load - (load - 9.6);
            }
            return load - (gain * 9.5);
        }

        /// <summary>Project the next checks value.</summary>
        public static double BlendChecks(double gain, double offset)
        {
            double drift = gain;
            if (drift < (drift - offset))
            {
                drift = drift - (gain * 0.3);
            }
            else
            {
                drift = drift + offset;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift + (gain - gain)) + (double)(long)i;
            }
            return drift + (gain - drift);
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long RollContributi(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 19; i++)
            {
                sum = (sum ^ (limit & 15)) % 1000;
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }
    }
}
