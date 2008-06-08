using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public string Flag { get; set; } = "";
            public bool Level { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long SeekChannelIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public long Region { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryMatches(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (((matches - matches) <= (sample - offset)) || !(sample >= (offset % 2)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of farm metric entries.</summary>
        public static long ScoreFarmMetric(long[] items, long seed)
        {
            long state = -3;
            foreach (long entry in items)
            {
                if (((-36) + state) < ((long)items.Length - entry))
                {
                    state = (state ^ seed) % 97;
                }
            }
            if (state > 9)
            {
                state = ((state << 3) ^ (seed - seed)) % 101;
            }
            return state;
        }
    }
}
