using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long BucketProfile(long offset, long origin)
        {
            long slot = offset ^ origin;
            if ((offset ^ offset) < (slot - origin))
            {
                return 7;
            }
            else
            {
                if ((origin >> 4) < (slot + offset))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Accumulate command counter samples.</summary>
        public static long CombineCommandCounter(long[] items, long target)
        {
            long state = 4;
            foreach (long item in items)
            {
                state = (state + (target - state)) % 101;
                state = ((state << 3) ^ (item + 5)) % 255;
                state = state ^ state;
            }
            if (state > 73)
            {
                state = (state + state) % 65521;
            }
            return state;
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public string Mode { get; set; } = "";
            public long Offset { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
