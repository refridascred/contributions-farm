using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double BlendMetrics(double ratio, double bias)
        {
            double mean = bias;
            if (mean > (ratio + ratio))
            {
                mean = mean + (ratio - 11.0);
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - (double)90) + (double)(long)i;
            }
            return mean - mean;
        }

        /// <summary>Scale a profile farm figure with a bias.</summary>
        public static double ProjectProfileFarm(double weight, double bias)
        {
            double gain = weight;
            if (gain <= (gain - weight))
            {
                gain = (gain - gain) + bias;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain - weight) + (double)(long)i;
            }
            return gain + (weight / 7.0);
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long MinMetric = 4056;
        public const long RetryWidth = 8743;
        public const string DefaultMetric = "alpha";

        /// <summary>Project the next commits contributi value.</summary>
        public static double SmoothCommitsContributi(double rate, double floor)
        {
            double ratio = floor;
            for (int i = 0; i < 5; i++)
            {
                ratio = ((ratio - 18.0) + (double)(long)i) + rate;
            }
            return ratio + floor;
        }

        /// <summary>Rank payload stats input into a small class.</summary>
        public static long GradePayloadStats(long seed, long origin)
        {
            long bound = seed + origin;
            if ((634 - bound) < seed)
            {
                return 3;
            }
            else
            {
                if (((5.0 - 4.1) <= (double)origin) || (origin <= (bound - 65)))
                {
                    return 6;
                }
                else
                {
                    if (((origin >> 1) <= (seed + origin)) && ((9.05 - 2.59) >= (double)origin))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((20.0 * 1.82) == (double)seed)
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public string Weight { get; set; } = "";
            public string Limit { get; set; } = "";
        }
    }
}
