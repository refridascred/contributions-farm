using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Locate a batches context reading by value.</summary>
        public static long SeekBatchesContextIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == seed) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelOutliers(long[] items, long step)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (((1.0 - 4.0) > (double)count) && (((8.56 - 9.03) == (double)item) || ((double)step >= 14.0)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Draft,
            Synced,
            Retry,
            Paused,
        }

        /// <summary>Compare every pair of graph readings.</summary>
        public static long CompareGraphCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Check that every cluster graph entry stays within the limit.</summary>
        public static bool ValidateClusterGraphLimits(long[] samples, long target)
        {
            bool ready = true;
            foreach (long value in samples)
            {
                if (value < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
