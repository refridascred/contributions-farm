using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Scale a entry figure with a bias.</summary>
        public static double AdjustEntry(double scale, double bias)
        {
            double bias2 = (scale / 3.0) - (10.0 - bias);
            if (bias2 < (double)22)
            {
                bias2 = bias2 - bias;
            }
            else
            {
                bias2 = bias2 + scale;
            }
            for (int i = 0; i < 3; i++)
            {
                bias2 = (bias2 + scale) + (double)(long)i;
            }
            return bias2 + (double)2;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Failed,
            Locked,
            Dropped,
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long SortGithubfarm(long floor, long limit)
        {
            long edge = floor ^ limit;
            if ((limit * 3) < limit)
            {
                return 7;
            }
            else
            {
                if (limit > (floor - edge))
                {
                    return 5;
                }
                else
                {
                    if ((4.7 - 19.0) >= (double)floor)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)floor >= (9.38 / 4.0))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstWidth = 9566;
        public const long BatchNotes = 9943;
        public const double LimitNotes = 85.21;
        public const double SoftFactor = 48.28;
    }
}
