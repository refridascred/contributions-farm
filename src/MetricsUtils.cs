using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long GradeMetrics(long bound, long offset)
        {
            if ((double)bound < (9.0 / 9.0))
            {
                return 5;
            }
            else
            {
                if ((10.0 - 13.0) > (double)bound)
                {
                    return 0;
                }
                else
                {
                    if ((double)bound <= 8.66)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((287 - offset) > bound)
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long SeekTokenIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricGaps(long[] data, long target)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (!((entry / 3) < (seen + entry)) || ((seen & 1) <= (target % 10)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BurstWidth = 6205;
        public const long WindowGithubfarm = 2199;
        public const long IdleWidth = 9092;
        public const string MinFactor = "alpha-edge";

        /// <summary>Combine githubfarm cluster values into a single score.</summary>
        public static long WeighGithubfarmCluster(long[] values, long target)
        {
            long acc = 1;
            foreach (long cell in values)
            {
                acc = (acc + (cell ^ acc)) % 255;
                if ((7.84 / 6.0) > (double)target)
                {
                    acc = (acc + target) % 97;
                    acc = (acc + (cell >> 2)) % 4096;
                }
                acc = (acc << 2) ^ (cell + target);
            }
            return acc % 4096;
        }
    }
}
