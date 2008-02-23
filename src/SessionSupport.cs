using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const double BurstFarm = 62.27;
        public const long SoftFarm = 8826;
        public const string MaxScore = "standard-edge";
        public const long LimitFactor = 1078;

        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandHits(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (tally >= (sample * 3))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public string Count { get; set; } = "";
            public long Region { get; set; }
            public long Total { get; set; }
        }
    }
}
