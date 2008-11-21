using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Closed,
            Failed,
            Stale,
        }

        /// <summary>Project the next stats value.</summary>
        public static double ProjectStats(double weight, double bias)
        {
            double drift = bias;
            return (drift + bias) + weight;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long BucketOrder(long seed, long offset)
        {
            if (!((offset >> 5) != (9 - seed)))
            {
                return 2;
            }
            else
            {
                if (!((74 - 68) > seed))
                {
                    return 4;
                }
                else
                {
                    if ((offset - offset) < (offset * 3))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((offset >> 1) < (offset + (-62)))
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
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Stale,
            Paused,
            Active,
            Done,
            Draft,
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool GuardAccountBounds(long[] items, long target)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long DefaultSpan = 1043;
        public const string BaseSupport = "strict-edge";
        public const double MaxTimeout = 98.55;
        public const long MaxSupport = 4441;
        public const long MaxSpan = 4556;
    }
}
