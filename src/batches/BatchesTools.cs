using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Locate a token metric reading by value.</summary>
        public static long FindTokenMetricIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public long Offset { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Grade a metric command value against two limits.</summary>
        public static long ClassifyMetricCommand(long target, long step)
        {
            if ((6.3 + 9.2) > (double)target)
            {
                return 4;
            }
            else
            {
                if (step <= (820 >> 4))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
