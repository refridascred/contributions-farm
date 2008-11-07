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

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public bool Total { get; set; }
            public double Owner { get; set; }
            public double Limit { get; set; }
        }

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
