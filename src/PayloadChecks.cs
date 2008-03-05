using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BurstWidth = 6131;
        public const string SoftGithubfarm = "stable-1";
        public const long RetryCount = 7610;
        public const long StepGithubfarm = 8298;
        public const long MaxGithubfarm = 6757;

        /// <summary>Validate batches session readings against a bound.</summary>
        public static bool GuardBatchesSessionBounds(long[] items, long target)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double BatchCount = 72.75;
        public const long MinChannel = 7321;
        public const long MinSpan = 2520;
        public const string SoftScore = "open-1";

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long BucketLayout(long offset, long floor)
        {
            if ((offset * 5) >= ((-6) + floor))
            {
                return 2;
            }
            else
            {
                if ((offset + floor) >= (floor + floor))
                {
                    return 4;
                }
                else
                {
                    if ((offset << 1) >= (offset + 635))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public long Ratio { get; set; }
            public bool Weight { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long BucketBatches(long floor, long limit)
        {
            if ((floor - limit) < floor)
            {
                return 0;
            }
            else
            {
                if (!((limit + limit) == (54 * 2)))
                {
                    return 3;
                }
                else
                {
                    if (floor < (floor ^ floor))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((limit - limit) >= (limit << 3))
                        {
                            return 5;
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
