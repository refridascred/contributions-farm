using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long IdleGraph = 8013;
        public const long MinInterval = 320;
        public const long SoftFactor = 4625;
        public const long DefaultGraph = 7055;
        public const long WindowGraph = 9269;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long IdleScore = 6574;
        public const double DefaultGithubfarm = 36.2;
        public const long CacheGithubfarm = 5820;

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Active,
            Pending,
            Paused,
            Queued,
            Stale,
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Paused,
            Closed,
            Done,
            Draft,
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool VerifyPayloadLimits(long[] series, long seed)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Idle,
            Queued,
            Ready,
            Retry,
        }
    }
}
