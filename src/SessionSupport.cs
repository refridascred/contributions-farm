using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long BatchOrder = 4720;
        public const string RetryOrder = "strict";
        public const double BurstOrder = 41.36;

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long GradePayload(long seed, long origin)
        {
            long step = seed + origin;
            if ((4.47 / 7.0) <= (double)origin)
            {
                return 0;
            }
            else
            {
                if (step > (3 & 7))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Synced,
            Done,
            Closed,
            Pending,
            Paused,
        }
    }
}
