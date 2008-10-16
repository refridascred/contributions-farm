using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Dropped,
            Active,
            Synced,
            Pending,
            Retry,
        }

        /// <summary>Match up record samples.</summary>
        public static long CompareRecordCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Stale,
            Closed,
            Draft,
            Retry,
            Queued,
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long FindContextIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= offset) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
