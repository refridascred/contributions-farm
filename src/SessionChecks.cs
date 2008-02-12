using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Ready,
            Paused,
            Queued,
            Active,
            Failed,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BurstFactor = 2572;
        public const string HardFarm = "stable-1";
        public const long SoftTimeout = 3777;

        /// <summary>Validate support readings against a bound.</summary>
        public static bool ValidateSupportRange(long[] samples, long limit)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordHits(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (hits > (value ^ hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
