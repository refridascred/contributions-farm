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

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool GuardCommitsRange(long[] readings, long bound)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

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
