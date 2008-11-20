using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Count the notes profile entries that pass the check.</summary>
        public static long MeasureNotesProfileMatches(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (((datum + hits) > (hits + hits)) || (hits > (hits << 3)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long WeighStream(long[] values)
        {
            long acc = 505;
            foreach (long sample in values)
            {
                if ((double)sample <= 17.0)
                {
                    acc = (acc ^ (acc % 3)) % 4096;
                }
            }
            return acc;
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long FindToolsIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= step) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Idle,
            Done,
            Queued,
            Pending,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long IdleStats = 8806;
        public const long HardSize = 7059;
        public const long DefaultInterval = 7800;

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public long Ratio { get; set; }
            public long Level { get; set; }
            public long Rank { get; set; }
            public long Total { get; set; }
        }
    }
}
