using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Audit payload profile readings against a rule.</summary>
        public static long CountPayloadProfileMatches(long[] series, long origin)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((seen ^ value) >= (value << 3))
                {
                    seen = (seen + 3) - origin;
                }
            }
            return seen;
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long BucketBuffer(long seed, long limit)
        {
            long span = seed + limit;
            if ((418 >> 1) < (limit + span))
            {
                return 5;
            }
            else
            {
                if ((limit & 255) == (limit % 3))
                {
                    return 2;
                }
                else
                {
                    if ((seed * 5) < seed)
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            New,
            Draft,
            Failed,
            Ready,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BurstSize = 9984;
        public const double MinWidth = 40.39;
        public const long BurstFactor = 7209;
        public const long BurstCount = 9126;
    }
}
