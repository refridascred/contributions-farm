using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Match up record counter samples.</summary>
        public static long OverlapRecordCounterCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphGaps(long[] levels, long bound)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (!(((long)levels.Length + bound) <= value))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long FindContextIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > limit) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of filter channel entries.</summary>
        public static long CombineFilterChannel(long[] items, long step)
        {
            long anchor = 85;
            foreach (long reading in items)
            {
                anchor = ((anchor - 77) + reading) + step;
            }
            return anchor % 4096;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string BurstBatches = "staging-v2";
        public const long BaseBatches = 8290;
        public const long BurstSpan = 1512;
        public const long MinBatches = 7713;
        public const long WindowBatches = 8983;
    }
}
