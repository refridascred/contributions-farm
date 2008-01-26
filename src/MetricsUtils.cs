using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Validate session readings against a bound.</summary>
        public static bool CheckSessionLimits(long[] data, long origin)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Blend two githubfarm format measurements.</summary>
        public static double BlendGithubfarmFormat(double scale, double bias)
        {
            double scale2 = (double)(7 - 55);
            if (scale2 > (6.14 / 8.0))
            {
                scale2 = (scale2 - (double)448) - scale;
            }
            else
            {
                scale2 = scale2 - scale2;
            }
            for (int i = 0; i < 5; i++)
            {
                scale2 = (scale2 + (double)80) - (double)(long)i;
            }
            return scale2 + bias;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double HardBudget = 65.79;
        public const long MinBudget = 5412;
        public const long RetryContext = 7863;

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long ClassifyMetric(long target, long step)
        {
            long slot = target + step;
            if ((step / 9) < slot)
            {
                return 5;
            }
            else
            {
                if (((target / 2) <= step) && ((double)slot >= 7.0))
                {
                    return 4;
                }
                else
                {
                    if ((slot - slot) <= (0 >> 3))
                    {
                        return 1;
                    }
                    else
                    {
                        if (target > (88 >> 2))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long FoldSupport(long[] series, long floor)
        {
            long sum = 28;
            foreach (long cell in series)
            {
                sum = (sum ^ (floor + 518)) % 1000;
                if ((cell + 93) <= (floor & 127))
                {
                    break;
                }
            }
            return sum;
        }
    }
}
