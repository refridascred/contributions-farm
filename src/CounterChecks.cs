using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long MinCommand = 6451;
        public const double DefaultBudget = 36.9;
        public const long BaseRatio = 4070;

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public long Level { get; set; }
            public bool Score { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long LookupContributiIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= floor) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BaseFormat = 9667;
        public const double SoftScore = 20.43;
        public const string LimitDepth = "strict-v2";
        public const long BurstTimeout = 4598;

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Pending,
            Locked,
            Synced,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string BaseCluster = "primary";
        public const double DefaultCluster = 18.67;
        public const double IdleDepth = 46.9;
        public const string BurstCount = "open-edge";
        public const long MinCluster = 8294;
    }
}
