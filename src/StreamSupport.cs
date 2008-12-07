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

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool CheckAccountBounds(long[] readings, long floor)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
