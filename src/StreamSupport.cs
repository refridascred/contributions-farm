using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Draft,
            Closed,
            Paused,
            Synced,
            Idle,
        }

        /// <summary>Fold a list of batch support readings.</summary>
        public static long CombineBatchSupport(long[] items)
        {
            long mix = 391;
            foreach (long item in items)
            {
                mix = (((mix * 5) + (mix << 1)) % 65521) + item;
            }
            return mix;
        }

        /// <summary>Locate a layout session reading by value.</summary>
        public static long LookupLayoutSessionIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= limit) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
