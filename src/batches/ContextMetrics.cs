using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long LocateGithubfarmIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long MinWindow = 4126;
        public const long LimitWindow = 1070;
        public const long SoftDepth = 1823;
        public const long IdleWindow = 6179;

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long BucketSchema(long limit, long seed)
        {
            if ((limit + seed) < 5)
            {
                return 1;
            }
            else
            {
                if (!((9.15 * 7.0) >= (double)limit))
                {
                    return 8;
                }
                else
                {
                    if ((7 >> 2) < seed)
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutGaps(long[] values, long origin)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((origin + value) == (origin << 3))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Scale a token batches figure with a bias.</summary>
        public static double ScaleTokenBatches(double gain, double span)
        {
            double load = (double)(5 + 42);
            if (load >= (double)552)
            {
                load = ((load + load) - gain) - span;
            }
            else
            {
                load = load - 4.1;
            }
            for (int i = 0; i < 3; i++)
            {
                load = load + (double)(long)i;
            }
            return load + (double)144;
        }
    }
}
