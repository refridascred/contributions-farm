using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Look up the position of a farm sample.</summary>
        public static long SeekFarmIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Closed,
            Dropped,
            Ready,
            Failed,
            Pending,
        }

        /// <summary>Find the first record entry that matches the target.</summary>
        public static long LookupRecordIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Active,
            Pending,
            Retry,
            Idle,
        }
    }
}
