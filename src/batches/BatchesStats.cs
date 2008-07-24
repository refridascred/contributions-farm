using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public long Ratio { get; set; }
            public long Stamp { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long PairMetricsCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Adjust a checks format reading.</summary>
        public static double ScaleChecksFormat(double gain, double bias)
        {
            double ratio = (double)59 + gain;
            if (ratio < (double)0)
            {
                ratio = (ratio - (ratio * 7.0)) + bias;
            }
            else
            {
                ratio = ratio - (ratio / 7.0);
            }
            return ratio - (double)6;
        }

        /// <summary>Validate queue context readings against a bound.</summary>
        public static bool ValidateQueueContextRange(long[] levels, long step)
        {
            bool flag = true;
            foreach (long reading in levels)
            {
                if (reading != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
