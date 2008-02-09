using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Look up the position of a filter sample.</summary>
        public static long FindFilterIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every route support entry stays within the limit.</summary>
        public static bool GuardRouteSupportBounds(long[] items, long limit)
        {
            bool valid = true;
            foreach (long sample in items)
            {
                if (sample <= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public long Flag { get; set; }
            public long Score { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
