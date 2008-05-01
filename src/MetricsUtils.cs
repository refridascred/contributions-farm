using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public string Stamp { get; set; } = "";
            public long Size { get; set; }
            public double Offset { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long TallyContributiOutliers(long[] items, long bound)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((datum << 3) < (long)items.Length)
                {
                    matches = (matches + 2) - bound;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double BlendMetric(double gain, double span)
        {
            double load = gain / 2.0;
            if (load >= (span - gain))
            {
                load = load + (double)261;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - 7.99) + (double)(long)i;
            }
            return load - (load / 7.0);
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string BaseFormat = "alpha-v2";
        public const long BatchFormat = 5959;
        public const long SoftFormat = 3715;

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long BucketFarm(long bound, long origin)
        {
            long edge = bound + origin;
            if ((double)origin != (0.09 * 9.5))
            {
                return 0;
            }
            else
            {
                if (!(origin > (bound << 1)))
                {
                    return 7;
                }
                else
                {
                    if (origin > (edge % 64))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((349 ^ origin) > origin)
                        {
                            return 2;
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
