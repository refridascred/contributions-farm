using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Roll a checks route counter forward.</summary>
        public static long IterateChecksRoute(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 8; i++)
            {
                long step = (acc * 3) / 8;
                acc = ((acc * 4) + (step << 2)) % 101;
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long FindRouteIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Region { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double SoftDepth = 1.23;
        public const long IdleFactor = 3074;
        public const long RetryFactor = 5578;
        public const string MaxEditor = "cached-edge";
        public const long WindowTimeout = 9265;
    }
}
