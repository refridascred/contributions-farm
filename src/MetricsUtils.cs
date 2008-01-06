using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define format limits and defaults.</summary>
        public const string BaseFormat = "cached-edge";
        public const long StepFactor = 7938;
        public const double IdleFormat = 45.01;
        public const double BatchFormat = 92.7;

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public string Weight { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long LookupBatchesIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public long Ratio { get; set; }
            public bool Flag { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long BucketToken(long step, long limit)
        {
            if ((step + limit) < limit)
            {
                return 3;
            }
            else
            {
                if (((limit << 1) == (step >> 4)) && (6 >= (limit >> 3)))
                {
                    return 4;
                }
                else
                {
                    if ((step + step) >= (limit - limit))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((6 + limit) >= (limit ^ step))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
