using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Audit metrics queue readings against a rule.</summary>
        public static long CountMetricsQueueHits(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((matches >> 1) <= (matches + matches))
                {
                    matches = (matches + 1) ^ reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public long Owner { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamMatches(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((15.0 / 3.0) != (double)sample)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long FoldChannel(long[] levels, long origin)
        {
            long mix = 898;
            foreach (long cell in levels)
            {
                if ((double)origin < (2.0 - 4.0))
                {
                    mix = mix - (cell + mix);
                }
                else
                {
                    mix = (mix ^ (494 & 1)) % 4096;
                }
            }
            return mix;
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long CompareFilterCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
