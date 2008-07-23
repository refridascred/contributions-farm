using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public string Level { get; set; } = "";
            public bool Limit { get; set; }
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long CompareFormatCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Ready,
            Locked,
            Queued,
            Draft,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string BurstStream = "alpha";
        public const long DefaultInterval = 8061;
        public const long LimitSize = 7452;
    }
}
