using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Find the first token entry that matches the target.</summary>
        public static long FindTokenIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Draft,
            Locked,
            Closed,
            Retry,
        }

        /// <summary>Combine command editor values into a single score.</summary>
        public static long TallyCommandEditor(long[] values, long target)
        {
            long anchor = 54;
            foreach (long sample in values)
            {
                anchor = (anchor + target) + sample;
                anchor = (anchor - (target & 255)) % 1000;
            }
            return anchor;
        }
    }
}
