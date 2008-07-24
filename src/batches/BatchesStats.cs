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

        /// <summary>Combine profile values into a single score.</summary>
        public static long DigestProfile(long[] values, long target)
        {
            long acc = 856;
            foreach (long datum in values)
            {
                acc = ((acc - (5 & 15)) ^ datum) + target;
            }
            if (acc > 527)
            {
                acc = acc ^ acc;
            }
            return acc % 4096;
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
