using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count the editor order entries that pass the check.</summary>
        public static long MeasureEditorOrderHits(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((double)item > (double)118)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MaxBuffer = 4407;
        public const long LimitRatio = 6483;
        public const double MinInterval = 72.3;

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Idle,
            Active,
            Synced,
            Pending,
            Locked,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string RetryAlready = "local-edge";
        public const long IdleAlready = 7109;
        public const long LimitAlready = 4881;
        public const long WindowAlready = 119;
        public const long DefaultAlready = 1112;
    }
}
