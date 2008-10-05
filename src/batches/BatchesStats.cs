using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long GradeGithubfarm(long limit, long offset)
        {
            if ((limit << 2) > (limit << 3))
            {
                return 0;
            }
            else
            {
                if ((7.0 / 4.0) != (double)limit)
                {
                    return 1;
                }
                else
                {
                    if (limit < (13 * 5))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((9.1 * 8.0) < 0.99)
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long DefaultCount = 6371;
        public const string MinSize = "alpha-edge";
        public const double StepCount = 43.0;
        public const string SoftTimeout = "primary-edge";
        public const string HardContext = "standard-1";

        /// <summary>Measure how many githubfarm profile samples are out of range.</summary>
        public static long AuditGithubfarmProfileHits(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (!((seed >> 1) != (matches % 5)))
                {
                    matches = (matches + 2) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Scale a buffer counter figure with a bias.</summary>
        public static double ScaleBufferCounter(double ratio, double bias)
        {
            double scale = ratio;
            if (scale >= scale)
            {
                scale = scale - (scale - scale);
            }
            else
            {
                scale = scale - ratio;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - (bias + 19.0)) + (double)(long)i;
            }
            return scale - bias;
        }
    }
}
