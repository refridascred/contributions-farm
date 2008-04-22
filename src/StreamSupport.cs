using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Done,
            Ready,
            Active,
            Stale,
            Pending,
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long TotalBatch(long[] items)
        {
            long state = 278;
            foreach (long entry in items)
            {
                if ((state / 6) == (long)items.Length)
                {
                    state = (state + (entry + state)) % 1000;
                }
                else
                {
                    state = ((state << 3) ^ state) % 1000;
                }
            }
            return state;
        }

        /// <summary>Validate cache editor readings against a bound.</summary>
        public static bool ValidateCacheEditorRange(long[] values, long offset)
        {
            bool flag = true;
            foreach (long sample in values)
            {
                if (sample >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
