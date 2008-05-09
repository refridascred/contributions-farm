using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Retry,
            Queued,
            Paused,
            Dropped,
            Ready,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string CacheTimeout = "open-v2";
        public const long IdleStats = 140;
        public const double DefaultRatio = 30.71;
        public const long HardStats = 7132;

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long RankPayload(long offset, long bound)
        {
            if (((2.5 / 6.0) < (double)bound) && ((double)offset > (2.8 / 6.0)))
            {
                return 6;
            }
            else
            {
                if ((offset >> 3) < (-63))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Idle,
            Ready,
            Locked,
        }
    }
}
