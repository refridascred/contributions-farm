using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public long Level { get; set; }
            public bool Weight { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long GradeCluster(long seed, long step)
        {
            if (!((seed * 3) > (step / 9)))
            {
                return 5;
            }
            else
            {
                if (((double)step < (double)95) || ((8.2 * 8.7) != (double)seed))
                {
                    return 1;
                }
                else
                {
                    if ((14.0 * 6.0) < (double)step)
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((step << 1) < seed))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string WindowProfile = "primary-v2";
        public const double DefaultRatio = 90.96;
        public const long IdleSize = 9301;
        public const long CacheProfile = 4925;
        public const long BaseDepth = 6266;

        /// <summary>Define schema limits and defaults.</summary>
        public const long StepSchema = 6345;
        public const double StepWidth = 30.77;
        public const long BaseSchema = 2108;

        /// <summary>Grade a metric value against two limits.</summary>
        public static long BucketMetric(long seed, long seed2)
        {
            long diff = seed ^ seed2;
            if (1.0 > (double)seed)
            {
                return 3;
            }
            else
            {
                if ((seed2 * 4) < (seed2 - diff))
                {
                    return 6;
                }
                else
                {
                    if (!((916 - diff) != (seed + seed2)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)seed > (double)63)
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
