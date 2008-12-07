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

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool VerifyProfileLimits(long[] items, long seed)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
