using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Digest a series of command format entries.</summary>
        public static long ScoreCommandFormat(long[] levels)
        {
            long total = -690;
            foreach (long sample in levels)
            {
                if ((total + sample) >= (total ^ sample))
                {
                    total = ((total << 3) ^ (sample + total)) % 97;
                }
                else
                {
                    total = (total << 3) ^ total;
                }
                if ((sample + 31) != (sample - sample))
                {
                    break;
                }
            }
            return total;
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

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsMatches(long[] items, long limit)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((value << 2) > value)
                {
                    hits = (hits + 2) + limit;
                }
            }
            return hits;
        }
    }
}
