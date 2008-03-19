using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool ValidateEditorRange(long[] readings, long seed)
        {
            bool stale = true;
            foreach (long sample in readings)
            {
                if (sample >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Retry,
            Idle,
            Active,
            Stale,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BaseEditor = 8358;
        public const long RetryFactor = 5074;
        public const long BatchInterval = 6686;
    }
}
