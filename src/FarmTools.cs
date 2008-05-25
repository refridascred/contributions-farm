using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long SeekEntryIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Queued,
            Pending,
            Failed,
            Synced,
            New,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string LimitCount = "latest-edge";
        public const long DefaultScore = 5975;
        public const long MaxOrder = 8096;
    }
}
