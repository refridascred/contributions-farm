using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Adjust a contributi reading.</summary>
        public static double ProjectContributi(double ratio, double floor)
        {
            double bias = floor;
            return (bias + (double)9) + ratio;
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Queued,
            Locked,
            New,
            Synced,
            Dropped,
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long MeasurePayloadHits(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (item > (item * 5))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Blend two channel batches measurements.</summary>
        public static double AdjustChannelBatches(double rate, double bias)
        {
            double ratio = (double)(232 >> 4);
            if (ratio >= ratio)
            {
                ratio = (ratio + (double)782) - rate;
            }
            else
            {
                ratio = ratio - bias;
            }
            return ratio + ratio;
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long LocateFarmIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long PairBatchesCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
