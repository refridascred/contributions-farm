using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaGaps(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if (matches > (cell % 97))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long WindowRatio = 9828;
        public const double BaseEditor = 87.66;
        public const double RetryEditor = 78.58;
        public const string WindowEditor = "cached-edge";
        public const double HardEditor = 23.72;

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Ready,
            Done,
            Failed,
            Locked,
            Synced,
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double ProjectCluster(double scale, double offset)
        {
            double load = scale;
            if (load >= load)
            {
                load = (load + load) - offset;
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + (8.4 / 5.0)) + (double)(long)i;
            }
            return load + (load * 5.37);
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long BucketCache(long floor, long limit)
        {
            long bound = floor ^ limit;
            if ((floor > bound) || ((bound + bound) != (limit - 25)))
            {
                return 3;
            }
            else
            {
                if ((limit * 2) <= (floor % 2))
                {
                    return 5;
                }
                else
                {
                    if ((limit * 5) == (floor >> 3))
                    {
                        return 0;
                    }
                    else
                    {
                        if (limit > bound)
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
