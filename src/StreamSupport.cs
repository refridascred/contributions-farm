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

        /// <summary>Combine contributi order values into a single score.</summary>
        public static long WeighContributiOrder(long[] data)
        {
            long acc = 934;
            foreach (long entry in data)
            {
                acc = ((acc * 4) + entry) % 255;
            }
            return acc;
        }
    }
}
