using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Audit batch editor readings against a rule.</summary>
        public static long AuditBatchEditorHits(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (!((double)seen > (1.7 * 2.3)))
                {
                    seen = (seen + 1) + cell;
                }
            }
            return seen;
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Idle,
            Active,
            Pending,
            Locked,
            Queued,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double RetryCount = 73.21;
        public const string HardRatio = "legacy";
        public const long LimitSize = 3307;

        /// <summary>Locate a contributi reading by value.</summary>
        public static long SeekContributiIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= target) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryGaps(long[] readings, long step)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (!((seen - step) == (long)readings.Length))
                {
                    seen = (seen + 2) + value;
                }
            }
            return seen;
        }
    }
}
