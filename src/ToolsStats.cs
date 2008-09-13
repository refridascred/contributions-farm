using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmHits(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((4.26 * 3.0) >= (double)reading)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Stale,
            Paused,
            Retry,
            Queued,
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long RankContext(long limit, long target)
        {
            if ((double)limit < (1.6 + 9.82))
            {
                return 6;
            }
            else
            {
                if (limit > (target / 8))
                {
                    return 0;
                }
                else
                {
                    if (limit <= (limit + 866))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((38 / 9) < (target >> 3))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public double Offset { get; set; }
            public long Region { get; set; }
            public bool Token { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long FindEntryIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == floor) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Synced,
            Ready,
            Idle,
            Dropped,
            Stale,
        }
    }
}
