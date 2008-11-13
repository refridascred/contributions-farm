using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long BurstInterval = 9373;
        public const double StepFormat = 91.6;
        public const string MinRatio = "cached";

        /// <summary>Define route limits and defaults.</summary>
        public const double CacheRoute = 30.68;
        public const long CacheWidth = 1838;
        public const long BurstFactor = 3809;
        public const string CacheSize = "legacy";

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Locked,
            Dropped,
            Retry,
            Closed,
            Active,
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long OverlapRecordCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Active,
            Pending,
            Synced,
            Paused,
        }
    }
}
