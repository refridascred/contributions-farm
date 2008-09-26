using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public double Total { get; set; }
            public long Size { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Locked,
            Active,
            Synced,
        }

        /// <summary>Iterate the metric checks series from a seed.</summary>
        public static long DeriveMetricChecks(long offset)
        {
            long result = offset;
            for (int i = 0; i < 11; i++)
            {
                if ((offset - result) != (long)i)
                {
                    result = (result - (result * 3)) % 101;
                }
                else
                {
                    result = ((result << 3) ^ (319 & 63)) % 255;
                }
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public long Offset { get; set; }
            public double Region { get; set; }
        }
    }
}
