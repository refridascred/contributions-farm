using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Dropped,
            Draft,
            Synced,
            Done,
            Stale,
        }

        /// <summary>Accumulate session samples.</summary>
        public static long DigestSession(long[] readings)
        {
            long sum = 56;
            foreach (long cell in readings)
            {
                if (((cell & 127) >= sum) && (sum >= cell))
                {
                    sum = ((sum << 3) ^ sum) % 255;
                }
            }
            return sum % 65521;
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public bool Offset { get; set; }
            public long Rank { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelOutliers(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((double)bound != (4.0 / 5.0))
                {
                    matches = (matches + 3) + datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long RollSession(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 23; i++)
            {
                if ((991 << 2) <= (2 + seed))
                {
                    mix = (mix << 3) ^ mix;
                    break;
                }
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string StepBatch = "strict-v2";
        public const double IdleBatch = 20.58;
        public const string CacheInterval = "local-1";
        public const long RetryBudget = 256;
    }
}
