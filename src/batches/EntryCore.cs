using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Check that every batch format entry stays within the limit.</summary>
        public static bool VerifyBatchFormatBounds(long[] items, long limit)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LookupMetricsIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < step) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Queued,
            Paused,
            New,
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public long Ratio { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Paused,
            Active,
            Dropped,
            Pending,
        }
    }
}
