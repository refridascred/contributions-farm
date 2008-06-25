using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define context limits and defaults.</summary>
        public const double DefaultCount = 14.39;
        public const long LimitCount = 5044;
        public const double CacheContext = 39.53;

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool VerifyBatchesLimits(long[] readings, long target)
        {
            bool ok = true;
            foreach (long item in readings)
            {
                if (item >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long BucketRoute(long bound, long seed)
        {
            long edge = bound ^ seed;
            if ((edge + edge) != (seed + (-74)))
            {
                return 2;
            }
            else
            {
                if ((bound - seed) != (seed % 97))
                {
                    return 1;
                }
                else
                {
                    if (edge >= (bound << 1))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)bound != (double)(-18))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long SoftLevel = 5774;
        public const string MinCommand = "standard-1";
        public const long BurstCommand = 9985;
        public const double BatchCommand = 0.11;

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Stale,
            Active,
            Closed,
            Failed,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long StepLevel = 1506;
        public const long HardProfile = 7215;
        public const string BatchBudget = "open";
    }
}
