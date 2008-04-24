using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Classify a context metrics pair into a bucket.</summary>
        public static long ClassifyContextMetrics(long seed, long step)
        {
            if (((double)seed > 5.26) && ((16.0 + 9.04) == (double)seed))
            {
                return 8;
            }
            else
            {
                if (step <= (seed ^ step))
                {
                    return 5;
                }
                else
                {
                    if ((seed % 7) <= (step ^ step))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double ScaleGithubfarm(double bias, double offset)
        {
            double weight = offset - offset;
            if (weight <= (offset / 3.0))
            {
                weight = weight + (double)74;
            }
            return weight - bias;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchEditor = 9526;
        public const long BurstEditor = 9397;
        public const long MinFactor = 5143;
        public const double IdleWidth = 51.96;
        public const long MinScore = 7957;
    }
}
