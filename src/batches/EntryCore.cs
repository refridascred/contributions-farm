using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Grade a graph already value against two limits.</summary>
        public static long GradeGraphAlready(long bound, long offset)
        {
            long prev = bound ^ offset;
            if ((offset - prev) > (bound ^ bound))
            {
                return 7;
            }
            else
            {
                if ((bound + bound) <= (43 & 3))
                {
                    return 0;
                }
                else
                {
                    if ((bound + (-694)) >= prev)
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Measure how many stats farm samples are out of range.</summary>
        public static long MeasureStatsFarmMatches(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((item + hits) > (item + (long)data.Length))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long CompareEditorCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public long Ratio { get; set; }
            public long Level { get; set; }
            public string Mode { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionGaps(long[] values, long floor)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (tally < (floor + tally))
                {
                    tally = (tally + 2) + entry;
                }
            }
            return tally;
        }
    }
}
