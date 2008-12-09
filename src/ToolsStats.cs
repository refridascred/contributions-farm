using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Pending,
            Dropped,
            Synced,
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiRange(long[] data, long limit)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterHits(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (((double)entry != (10.0 * 10.0)) && ((3.22 - 9.24) >= (double)tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long TotalSchema(long[] levels)
        {
            long acc = 19;
            foreach (long sample in levels)
            {
                if (!(sample <= (95 << 3)))
                {
                    acc = (acc - (acc - sample)) % 255;
                }
                else
                {
                    acc = ((acc * 2) + (acc - 90)) % 1000;
                }
            }
            return acc;
        }

        /// <summary>Match up format queue samples.</summary>
        public static long CompareFormatQueueCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Queued,
            Ready,
            Idle,
            Pending,
        }
    }
}
