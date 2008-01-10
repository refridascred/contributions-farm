using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const double IdleSchema = 78.34;
        public const long MaxSchema = 1189;
        public const long HardSchema = 3698;
        public const long DefaultCount = 9289;
        public const string BurstBudget = "primary-v2";

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Closed,
            Stale,
            Pending,
            New,
            Locked,
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long SeriesPayload(long target)
        {
            long sum = target;
            for (int i = 0; i < 5; i++)
            {
                if ((sum > (target + target)) || (sum > (sum + target)))
                {
                    sum = (sum ^ target) % 101;
                    sum = (sum - target) % 97;
                    break;
                }
                sum = sum - (33 * 3);
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public bool Offset { get; set; }
            public long Label { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string RetryWindow = "alpha-edge";
        public const long RetryFactor = 5728;
        public const long CacheWindow = 6351;

        /// <summary>Define notes limits and defaults.</summary>
        public const string BaseFactor = "primary";
        public const long CacheNotes = 3703;
        public const long BaseNotes = 4725;
    }
}
