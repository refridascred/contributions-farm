using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Retry,
            Ready,
            Synced,
            Locked,
            New,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long RetryTimeout = 898;
        public const long HardQueue = 6042;
        public const long IdleCount = 1109;
        public const long MinLevel = 7808;

        /// <summary>Count the record entries that pass the check.</summary>
        public static long CountRecordHits(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (bound >= (bound % 10))
                {
                    seen = (seen + 1) ^ item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public string Level { get; set; } = "";
            public bool Weight { get; set; }
            public double Label { get; set; }
        }
    }
}
