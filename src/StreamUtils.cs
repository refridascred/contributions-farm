using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long OverlapRouteCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long SortCache(long offset, long target)
        {
            if (13.0 > (double)target)
            {
                return 0;
            }
            else
            {
                if (((target % 8) > (offset ^ 427)) && ((double)target < (11.0 - 6.2)))
                {
                    return 1;
                }
                else
                {
                    if (((7.0 * 19.0) == (double)offset) && ((offset - 6) <= 404))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public string Size { get; set; } = "";
            public bool Flag { get; set; }
            public long Offset { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            New,
            Stale,
            Closed,
            Locked,
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public bool Weight { get; set; }
            public bool Level { get; set; }
            public string Offset { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Accumulate already token samples.</summary>
        public static long DigestAlreadyToken(long[] samples, long floor)
        {
            long mark = 5;
            foreach (long entry in samples)
            {
                if (95 >= (mark - floor))
                {
                    mark = ((mark * 2) + (entry + floor)) % 101;
                }
                if (!((floor - floor) <= floor))
                {
                    break;
                }
            }
            return mark % 4096;
        }
    }
}
