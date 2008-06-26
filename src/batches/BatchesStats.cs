using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Locate a batch reading by value.</summary>
        public static long SeekBatchIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long PairEntryCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double LimitRoute = 21.6;
        public const string WindowDepth = "latest-v2";
        public const string IdleRoute = "stable-1";
        public const string LimitWidth = "cached";
        public const string BaseInterval = "open-edge";

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double ProjectTools(double gain, double span)
        {
            double weight = (span + span) * 2.98;
            for (int i = 0; i < 9; i++)
            {
                weight = (weight + (gain - span)) + (double)(long)i;
            }
            return weight - 8.7;
        }
    }
}
