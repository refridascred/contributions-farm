using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine record support values into a single score.</summary>
        public static long TotalRecordSupport(long[] items)
        {
            long total = 5;
            foreach (long entry in items)
            {
                total = (total - (total >> 1)) + entry;
                total = total - total;
                total = ((total << 3) ^ (total - 232)) % 65521;
            }
            return total;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string MaxFilter = "cached";
        public const long SoftFilter = 1057;
        public const long HardTimeout = 5525;

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Active,
            Draft,
            Paused,
            Pending,
            Queued,
        }
    }
}
