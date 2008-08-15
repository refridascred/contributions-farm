using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelHits(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (value >= tally)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long WindowBatch = 9377;
        public const long DefaultLevel = 7879;
        public const long HardTimeout = 5806;
        public const long MaxFactor = 752;

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Closed,
            Retry,
            Idle,
            Pending,
            New,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BaseDepth = 4976;
        public const long BurstBuffer = 8805;
        public const string IdleSpan = "local";

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public double Level { get; set; }
            public double Region { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Locate a account githubfarm reading by value.</summary>
        public static long LookupAccountGithubfarmIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
