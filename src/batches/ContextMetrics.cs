using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public long Level { get; set; }
            public long Label { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long LookupClusterIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < target) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of account metric entries.</summary>
        public static long CombineAccountMetric(long[] readings)
        {
            long score = 17;
            foreach (long cell in readings)
            {
                score = (score ^ cell) % 65521;
                score = (score * 2) + (cell + cell);
            }
            if (score > 0)
            {
                score = (score + (score ^ score)) % 255;
            }
            return score;
        }

        /// <summary>Measure how many context queue samples are out of range.</summary>
        public static long AuditContextQueueMatches(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((double)item >= (7.0 * 6.0))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a cluster entry sample.</summary>
        public static long LookupClusterEntryIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > target) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
