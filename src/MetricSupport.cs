using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long MinFarm = 7797;
        public const double BatchSize = 45.36;
        public const long RetryBudget = 5646;
        public const double StepFactor = 93.49;

        /// <summary>Match up tools samples.</summary>
        public static long MatchToolsCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Done,
            Synced,
            Active,
            Failed,
            Draft,
        }
    }
}
