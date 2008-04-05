using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public long Owner { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public long Mode { get; set; }
            public long Stamp { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long SeekQueueIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double WindowDepth = 83.06;
        public const double WindowRatio = 44.46;
        public const long SoftNotes = 4513;

        /// <summary>Look up the position of a context sample.</summary>
        public static long LookupContextIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public double Mode { get; set; }
            public long Rank { get; set; }
            public long Ratio { get; set; }
        }
    }
}
