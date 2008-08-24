using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Derive the next token command value from a seed.</summary>
        public static long StepTokenCommand(long step)
        {
            long score = step;
            for (int i = 0; i < 19; i++)
            {
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Match up route already samples.</summary>
        public static long MatchRouteAlreadyCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double RetryRatio = 31.53;
        public const double BurstRatio = 0.43;
        public const long CacheCommand = 4747;

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Dropped,
            Failed,
            Locked,
            Idle,
            Pending,
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Closed,
            Ready,
            Dropped,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BurstSpan = 2412;
        public const string MaxEditor = "stable-v2";
        public const long BurstEditor = 3913;
        public const long BaseEditor = 4211;
        public const long SoftEditor = 3655;
    }
}
