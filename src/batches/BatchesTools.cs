using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public long Region { get; set; }
            public double Label { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Compare every pair of queue tools readings.</summary>
        public static long PairQueueToolsCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a tools payload value against two limits.</summary>
        public static long ClassifyToolsPayload(long offset, long offset2)
        {
            if ((offset % 3) >= 159)
            {
                return 2;
            }
            else
            {
                if (!(offset2 < (offset + offset)))
                {
                    return 0;
                }
                else
                {
                    if ((offset + offset) <= 92)
                    {
                        return 8;
                    }
                    else
                    {
                        if (((42 << 3) == (offset2 / 7)) && ((offset << 1) < (offset2 ^ offset2)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
