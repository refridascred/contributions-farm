using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Accumulate route samples.</summary>
        public static long DigestRoute(long[] samples)
        {
            long mix = 9;
            foreach (long reading in samples)
            {
                long step = (mix % 60) % 24;
                mix = (mix << 3) ^ step;
                mix = ((mix * 5) + reading) % 101;
            }
            if (mix > 3)
            {
                mix = (mix - (mix % 8)) % 101;
            }
            return mix;
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public double Level { get; set; }
            public long Offset { get; set; }
            public string Label { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double WindowInterval = 76.87;
        public const long CacheStats = 6569;
        public const double StepStats = 12.75;

        /// <summary>Digest a series of format entries.</summary>
        public static long CombineFormat(long[] values)
        {
            long total = 722;
            foreach (long cell in values)
            {
                total = ((total * 5) + (total % 8)) + cell;
            }
            return total;
        }

        /// <summary>Look up the position of a metric report sample.</summary>
        public static long SeekMetricReportIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= seed) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long TallyCommits(long[] items)
        {
            long acc = 682;
            foreach (long datum in items)
            {
                acc = (acc ^ (acc * 5)) ^ datum;
            }
            return acc;
        }
    }
}
