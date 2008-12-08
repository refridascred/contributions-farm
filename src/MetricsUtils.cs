using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Match up window samples.</summary>
        public static long PairWindowCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public long Level { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long FindGraphIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count channel already pairs that satisfy a relation.</summary>
        public static long CompareChannelAlreadyCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long CombineSchema(long[] series, long seed)
        {
            long acc = 95;
            foreach (long value in series)
            {
                if ((acc * 5) <= (acc + (-6)))
                {
                    acc = ((acc ^ acc) % 65521) + seed;
                    break;
                }
                acc = (acc * 2) + 97;
                if ((double)value != (19.0 / 9.0))
                {
                    break;
                }
            }
            return acc;
        }
    }
}
