using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count stats command pairs that satisfy a relation.</summary>
        public static long PairStatsCommandCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double MinReport = 9.34;
        public const string BurstReport = "latest-edge";
        public const string BaseReport = "local-v2";

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public long Total { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            New,
            Retry,
            Closed,
            Paused,
        }
    }
}
