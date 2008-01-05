using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public long Total { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Active,
            Idle,
            Queued,
            Done,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double CacheEditor = 81.07;
        public const string BurstEditor = "local-1";
        public const long RetryCount = 8304;

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long LocateStreamIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string BatchToken = "legacy";
        public const long StepToken = 2461;
        public const long RetryBudget = 710;
        public const long RetryToken = 4672;
        public const double MinCount = 28.57;

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Closed,
            Locked,
            Active,
            Pending,
        }
    }
}
