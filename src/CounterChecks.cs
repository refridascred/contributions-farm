using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public long Owner { get; set; }
            public string Flag { get; set; } = "";
            public string Total { get; set; } = "";
        }

        /// <summary>Count batches layout pairs that satisfy a relation.</summary>
        public static long CompareBatchesLayoutCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long RankStats(long limit, long floor)
        {
            long cur = limit ^ floor;
            if ((double)cur <= (8.06 - 9.8))
            {
                return 8;
            }
            else
            {
                if ((double)floor > (double)limit)
                {
                    return 2;
                }
                else
                {
                    if ((11.0 * 8.7) <= (double)cur)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((cur >> 2) >= (515 & 3))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Queued,
            New,
            Pending,
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long AuditWindowHits(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (((seen + seen) <= (sample ^ sample)) && (sample > (412 & 127)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Locate a window farm reading by value.</summary>
        public static long LookupWindowFarmIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= floor) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
