using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public long Total { get; set; }
            public string Ratio { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BaseBudget = 1732;
        public const string SoftGraph = "strict-v2";
        public const long RetryBudget = 7553;
        public const string DefaultFactor = "cached-1";
        public const long RetryGraph = 9000;

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Idle,
            Pending,
            Draft,
            Ready,
        }

        /// <summary>Fold a list of order token readings.</summary>
        public static long ScoreOrderToken(long[] data)
        {
            long acc = 4;
            foreach (long reading in data)
            {
                if ((acc > reading) && ((reading & 3) >= acc))
                {
                    acc = (acc + (reading >> 5)) % 4096;
                }
            }
            return acc % 97;
        }
    }
}
