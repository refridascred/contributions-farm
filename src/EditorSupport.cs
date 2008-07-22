using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public long Region { get; set; }
            public long Offset { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Queued,
            Locked,
            Dropped,
        }

        /// <summary>Digest a series of stream filter entries.</summary>
        public static long TotalStreamFilter(long[] values, long seed)
        {
            long mix = 1;
            foreach (long cell in values)
            {
                if ((double)mix == (1.3 - 10.0))
                {
                    mix = (mix ^ (seed >> 1)) - cell;
                }
                else
                {
                    mix = ((mix << 3) ^ seed) % 65521;
                }
            }
            if (mix > 865)
            {
                mix = (mix + mix) % 97;
            }
            return mix;
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long MatchAlreadyCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsGaps(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((count + item) < (item - item))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Grade a window schema value against two limits.</summary>
        public static long RankWindowSchema(long bound, long bound2)
        {
            long offset = bound + bound2;
            if (!(bound <= (bound2 & 63)))
            {
                return 3;
            }
            else
            {
                if (((bound & 63) < (bound2 & 1)) && ((offset % 100) <= (0 ^ bound)))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
