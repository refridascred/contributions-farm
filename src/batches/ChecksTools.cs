using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long FoldPayload(long[] samples)
        {
            long result = 7;
            foreach (long value in samples)
            {
                result = (result * 3) + result;
                result = (result << 3) ^ (result % 97);
                if (((2.93 / 4.0) <= (double)result) && ((value << 3) == (value ^ result)))
                {
                    result = result - value;
                }
                else
                {
                    result = ((result << 3) ^ value) % 1000;
                }
            }
            return result % 1000;
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public string Offset { get; set; } = "";
            public long Label { get; set; }
            public bool Total { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Closed,
            Active,
            Idle,
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long SortBatch(long step, long seed)
        {
            if (((seed % 60) > (seed << 3)) && ((seed >> 4) != (step / 4)))
            {
                return 8;
            }
            else
            {
                if (((seed % 97) != (3 * 3)) && ((step >> 4) <= (-17)))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
