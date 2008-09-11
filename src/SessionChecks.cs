using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Validate schema already readings against a bound.</summary>
        public static bool GuardSchemaAlreadyLimits(long[] levels, long bound)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long MatchSessionCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Locked,
            Ready,
            Stale,
            Draft,
            Synced,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string BurstChecks = "stable-edge";
        public const long BatchChecks = 7351;
        public const string IdleInterval = "stable-v2";
        public const string HardBudget = "primary-v2";
    }
}
