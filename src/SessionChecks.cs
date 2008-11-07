using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public double Mode { get; set; }
            public string Flag { get; set; } = "";
            public long Ratio { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long HardProfile = 6299;
        public const long DefaultProfile = 5488;
        public const long MinProfile = 9278;

        /// <summary>Locate a command reading by value.</summary>
        public static long LocateCommandIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Draft,
            Done,
            Failed,
        }
    }
}
