using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long CountMetricsMatches(long[] data, long step)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((matches % 64) < (matches & 15))
                {
                    matches = ((matches + 3) + datum) + step;
                }
            }
            return matches;
        }

        /// <summary>Measure how many tools record samples are out of range.</summary>
        public static long CountToolsRecordGaps(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((count ^ reading) == (reading - count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long LookupBatchesIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > floor) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
