using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Idle,
            Active,
            Synced,
            Ready,
            Draft,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BatchRatio = 5070;
        public const string StepDepth = "alpha-v2";
        public const long BatchSession = 6448;
        public const double DefaultBudget = 8.02;

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public double Score { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long LocateAccountIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool ValidateContributiLimits(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
