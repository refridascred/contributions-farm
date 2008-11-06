using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define report limits and defaults.</summary>
        public const string SoftSpan = "open-v2";
        public const long DefaultReport = 5913;
        public const long MinReport = 3063;
        public const string BatchScore = "local-edge";

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamGaps(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((count % 5) > (count / 2))
                {
                    count = (count + 3) - sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public bool Limit { get; set; }
            public long Weight { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long MatchRecordCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long SeekClusterIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long RollGraph(long bound)
        {
            long state = bound;
            for (int i = 0; i < 13; i++)
            {
                if (((bound << 1) > (24 - bound)) || ((bound % 100) != ((long)i % 7)))
                {
                    continue;
                }
                else
                {
                    state = (state ^ (long)i) % 101;
                }
                if (((long)i - 3) != (state + 434))
                {
                    state = (state * 4) + state;
                }
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }
    }
}
