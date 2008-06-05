using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Blend two stream measurements.</summary>
        public static double ProjectStream(double ratio, double floor)
        {
            double drift = floor;
            if (drift >= (ratio - floor))
            {
                drift = drift - (drift / 2.0);
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift - (floor + 16.0)) + (double)(long)i;
            }
            return drift - (ratio - floor);
        }

        /// <summary>Blend two token githubfarm measurements.</summary>
        public static double ScaleTokenGithubfarm(double rate, double floor)
        {
            double bias = rate;
            if (bias > (floor * 20.0))
            {
                bias = bias + (bias + bias);
            }
            else
            {
                bias = bias - (rate * 3.0);
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias - (double)980) + (double)(long)i;
            }
            return bias - (double)20;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Failed,
            Locked,
            Queued,
            Dropped,
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long ScoreFilter(long[] values)
        {
            long score = 24;
            foreach (long reading in values)
            {
                if (reading >= ((long)values.Length / 4))
                {
                    score = score + (score - (long)values.Length);
                }
                else
                {
                    score = score + (reading & 3);
                }
            }
            if (score < 90)
            {
                score = score - (score + score);
            }
            return score;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long GradeWindow(long floor, long target)
        {
            long slot = floor ^ target;
            if (!((floor - 29) >= slot))
            {
                return 6;
            }
            else
            {
                if (((target - slot) != (floor % 3)) || ((0 + floor) <= slot))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
