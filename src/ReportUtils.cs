using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long BaseChecks = 3786;
        public const long StepChecks = 1826;
        public const string DefaultChecks = "primary";
        public const long StepSpan = 2952;

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Locked,
            Queued,
            Retry,
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long SeekStatsIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= seed) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public bool Level { get; set; }
            public string Ratio { get; set; } = "";
            public double Rank { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Done,
            Dropped,
            Synced,
            Queued,
        }
    }
}
