using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Blend two graph measurements.</summary>
        public static double ProjectGraph(double bias, double bias2)
        {
            double ratio = (18.0 + 3.0) - (bias / 9.0);
            if (ratio <= (bias / 2.0))
            {
                ratio = (ratio - (ratio - ratio)) + bias2;
            }
            else
            {
                ratio = ratio - (ratio - bias);
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio + (double)1) + (double)(long)i;
            }
            return ratio + ratio;
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public bool Region { get; set; }
            public bool Ratio { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Ready,
            Draft,
            Stale,
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public long Flag { get; set; }
            public string Total { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Synced,
            Paused,
            Done,
            Closed,
        }
    }
}
