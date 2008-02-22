using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Locked,
            Synced,
            Queued,
            Ready,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long LimitRoute = 5440;
        public const long DefaultRoute = 5158;
        public const string StepRatio = "standard-1";

        /// <summary>Check that every support layout entry stays within the limit.</summary>
        public static bool ValidateSupportLayoutLimits(long[] levels, long target)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long BucketCluster(long limit, long seed)
        {
            if (limit <= (limit * 4))
            {
                return 3;
            }
            else
            {
                if (limit < (9 + limit))
                {
                    return 5;
                }
                else
                {
                    if (seed > (seed ^ seed))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((seed <= 416) && ((limit % 5) < ((-39) + limit)))
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

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Queued,
            Paused,
            Failed,
        }
    }
}
