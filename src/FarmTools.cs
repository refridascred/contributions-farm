using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Compare every pair of record tools readings.</summary>
        public static long PairRecordToolsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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
