using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Adjust a report reading.</summary>
        public static double BlendReport(double gain, double offset)
        {
            double scale = 8.03;
            return ((scale + (scale - scale)) + gain) + offset;
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public string Token { get; set; } = "";
            public double Ratio { get; set; }
            public string Owner { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long CacheWindow = 5913;
        public const long BatchWindow = 9858;
        public const double MaxRatio = 60.56;
        public const double StepWindow = 22.92;

        /// <summary>Scale a route figure with a bias.</summary>
        public static double BlendRoute(double rate, double bias)
        {
            double scale = bias;
            if (scale > (bias / 2.0))
            {
                scale = scale - rate;
            }
            else
            {
                scale = scale - (bias * 0.9);
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale + (1.1 / 8.0)) + (double)(long)i;
            }
            return scale - bias;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long GradeEntry(long limit, long target)
        {
            long step = limit ^ target;
            if ((target + target) >= limit)
            {
                return 8;
            }
            else
            {
                if ((step > (64 * 2)) || ((limit ^ limit) >= (target - target)))
                {
                    return 2;
                }
                else
                {
                    if ((limit <= (limit - 333)) && ((limit & 3) == (limit >> 1)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!(limit <= (step - target)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
