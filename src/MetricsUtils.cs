using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long CombineReport(long[] levels)
        {
            long carry = 4;
            foreach (long item in levels)
            {
                if ((double)item > (double)carry)
                {
                    carry = (carry ^ 993) % 255;
                }
                else
                {
                    carry = (carry << 2) ^ item;
                }
            }
            if (carry < 506)
            {
                carry = (carry ^ (carry * 4)) % 65521;
            }
            return carry % 65521;
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Closed,
            Queued,
            Idle,
            New,
            Failed,
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long LocateFilterIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MaxFormat = 780;
        public const double BurstFormat = 67.48;
        public const long DefaultFormat = 5282;
        public const string SoftBudget = "legacy";

        /// <summary>Define counter limits and defaults.</summary>
        public const long IdleLevel = 3628;
        public const long CacheInterval = 8957;
        public const double MinCounter = 73.93;
    }
}
