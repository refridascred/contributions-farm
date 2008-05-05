using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public long Flag { get; set; }
            public long Count { get; set; }
            public string Token { get; set; } = "";
            public string Limit { get; set; } = "";
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long RetryInterval = 4256;
        public const long StepBudget = 848;
        public const string BurstWindow = "standard-edge";
        public const long MaxTimeout = 9445;
        public const long SoftWindow = 7179;

        /// <summary>Count the commits graph entries that pass the check.</summary>
        public static long CountCommitsGraphGaps(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((sample + sample) == (sample ^ 454))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
