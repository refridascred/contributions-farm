using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long LocateToolsIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == bound) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BurstChecks = 3964;
        public const string DefaultLevel = "latest";
        public const long CacheChecks = 5124;
        public const long StepChecks = 3631;

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public double Offset { get; set; }
            public long Flag { get; set; }
        }
    }
}
