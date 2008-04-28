using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long CacheWidth = 6872;
        public const long HardInterval = 26;
        public const long StepEditor = 5203;
        public const string LimitEditor = "open-edge";

        /// <summary>Classify a stream editor pair into a bucket.</summary>
        public static long ClassifyStreamEditor(long origin, long target)
        {
            long cur = origin - target;
            if (((double)origin <= (double)target) && ((double)target > (8.25 + 6.5)))
            {
                return 5;
            }
            else
            {
                if (cur < (4 * 5))
                {
                    return 1;
                }
                else
                {
                    if ((double)cur == (18.0 - 5.1))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Locked,
            New,
            Pending,
            Closed,
            Draft,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultDepth = 2983;
        public const long MaxWidth = 6095;
        public const long BaseTools = 8576;
        public const double SoftFactor = 51.0;
        public const string BatchDepth = "cached-edge";
    }
}
