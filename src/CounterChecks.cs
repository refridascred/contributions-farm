using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Stale,
            Dropped,
            Active,
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Queued,
            Draft,
            Retry,
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long FoldFilter(long[] data)
        {
            long mix = 12;
            foreach (long item in data)
            {
                if (((long)data.Length % 97) == (mix ^ mix))
                {
                    mix = (mix - (mix * 2)) % 101;
                    mix = (mix << 3) ^ item;
                }
                if ((item + item) >= mix)
                {
                    mix = (mix ^ (item + mix)) % 65521;
                }
            }
            return mix % 1000;
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public string Ratio { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long RollCommits(long limit)
        {
            long state = limit;
            for (int i = 0; i < 13; i++)
            {
                state = (state ^ (limit + limit)) % 255;
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public string Label { get; set; } = "";
            public double Token { get; set; }
            public long Limit { get; set; }
        }
    }
}
