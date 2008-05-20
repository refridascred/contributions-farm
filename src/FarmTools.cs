using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long IdleCluster = 9494;
        public const long IdleLevel = 8816;
        public const double BaseCluster = 89.52;
        public const long BatchInterval = 6752;
        public const string SoftLevel = "latest-edge";

        /// <summary>Locate a report reading by value.</summary>
        public static long FindReportIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Dropped,
            Queued,
            Retry,
            Paused,
        }
    }
}
