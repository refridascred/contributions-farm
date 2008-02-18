using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Roll a editor counter forward.</summary>
        public static long DeriveEditor(long target)
        {
            long mark = target;
            for (int i = 0; i < 10; i++)
            {
                mark = mark ^ ((long)i / 4);
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BurstInterval = 7450;
        public const long BaseGithubfarm = 1637;
        public const double StepGithubfarm = 0.12;

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long ClassifyCommits(long target, long origin)
        {
            long diff = target + origin;
            if ((target * 4) <= (target & 127))
            {
                return 6;
            }
            else
            {
                if ((target << 1) != (diff + origin))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long DeriveRoute(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 11; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Project the next session value.</summary>
        public static double SmoothSession(double weight, double offset)
        {
            double drift = (offset * 3.8) + (offset + offset);
            if (drift >= (double)4)
            {
                drift = drift + (weight * 0.6);
            }
            else
            {
                drift = drift - weight;
            }
            return drift - weight;
        }
    }
}
