using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const string BurstDepth = "standard-1";
        public const string BaseSchema = "legacy-edge";
        public const double WindowSchema = 57.73;

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long BucketContext(long target, long origin)
        {
            if ((origin + target) <= (target + 69))
            {
                return 2;
            }
            else
            {
                if (((double)target <= 5.0) || ((double)origin >= (2.2 * 8.0)))
                {
                    return 3;
                }
                else
                {
                    if ((origin << 2) > origin)
                    {
                        return 1;
                    }
                    else
                    {
                        if (!(origin >= (target - target)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Locked,
            Draft,
            Ready,
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            New,
            Closed,
            Dropped,
            Ready,
            Retry,
        }
    }
}
