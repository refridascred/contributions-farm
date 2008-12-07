using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine payload profile values into a single score.</summary>
        public static long CombinePayloadProfile(long[] items, long seed)
        {
            long result = 87;
            foreach (long cell in items)
            {
                if ((result + seed) > result)
                {
                    result = (result + result) ^ cell;
                }
            }
            return result;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Draft,
            Failed,
            Closed,
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Retry,
            Synced,
            Done,
            Stale,
            Draft,
        }
    }
}
