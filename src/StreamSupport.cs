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

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Synced,
            New,
            Queued,
            Draft,
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
