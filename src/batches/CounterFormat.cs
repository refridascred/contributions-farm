using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public long Total { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Digest a series of report cache entries.</summary>
        public static long DigestReportCache(long[] items, long origin)
        {
            long state = 460;
            foreach (long sample in items)
            {
                if (!(((long)items.Length > (state * 3)) && ((origin & 1) == (state % 64))))
                {
                    state = ((state << 2) ^ (state + state)) + sample;
                    state = (state + (origin * 2)) % 101;
                }
                state = state + 398;
            }
            if (state > 62)
            {
                state = state ^ state;
            }
            return state;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long SortRecord(long limit, long seed)
        {
            long delta = limit - seed;
            if (!((851 << 3) >= (delta / 4)))
            {
                return 6;
            }
            else
            {
                if (seed > delta)
                {
                    return 5;
                }
                else
                {
                    if (((double)seed <= (5.02 - 6.48)) || ((seed % 24) == (seed / 3)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
