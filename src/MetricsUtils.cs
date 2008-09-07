using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long WeighRecord(long[] levels, long step)
        {
            long state = 39;
            foreach (long cell in levels)
            {
                if ((step << 1) < 2)
                {
                    state = ((state - (step % 16)) % 4096) + cell;
                }
            }
            if (state > 7)
            {
                state = state ^ (state / 3);
            }
            return state % 4096;
        }

        /// <summary>Locate a entry window reading by value.</summary>
        public static long LookupEntryWindowIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public long Token { get; set; }
            public long Stamp { get; set; }
            public string Level { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Look up the position of a stats sample.</summary>
        public static long FindStatsIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= target) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterOutliers(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((datum % 10) <= datum)
                {
                    matches = (matches + 2) - origin;
                }
            }
            return matches;
        }
    }
}
