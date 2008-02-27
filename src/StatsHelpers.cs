using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Locked,
            Failed,
            Pending,
            Closed,
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public long Token { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Validate account token readings against a bound.</summary>
        public static bool ValidateAccountTokenRange(long[] series, long floor)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string WindowSchema = "cached-v2";
        public const long HardCount = 8900;
        public const long RetrySchema = 2268;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long StepBudget = 3670;
        public const long StepBuffer = 1380;
        public const long WindowSize = 9779;
        public const long BaseFactor = 6915;
        public const long HardBuffer = 9087;
    }
}
