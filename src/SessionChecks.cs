using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Find the first record tools entry that matches the target.</summary>
        public static long FindRecordToolsIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double RetryRatio = 46.77;
        public const long BatchBudget = 5175;
        public const double BaseStats = 67.82;
        public const long HardSize = 432;

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Retry,
            New,
            Pending,
            Paused,
            Done,
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public double Count { get; set; }
            public long Total { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
