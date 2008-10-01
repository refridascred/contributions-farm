using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const string StepPayload = "cached";
        public const long BatchSize = 808;
        public const double BatchPayload = 89.77;
        public const long LimitPayload = 8966;

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Locked,
            Ready,
            Dropped,
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Failed,
            Queued,
            Closed,
            Draft,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string BaseLevel = "fallback-edge";
        public const string MinCount = "standard-edge";
        public const string RetryLevel = "local-edge";
        public const string BurstCommand = "local-1";

        /// <summary>Digest a series of stats entries.</summary>
        public static long CombineStats(long[] series)
        {
            long result = 925;
            foreach (long sample in series)
            {
                if ((result + 82) > (sample ^ result))
                {
                    result = (result + (result & 15)) % 97;
                }
            }
            return result % 1000;
        }
    }
}
