using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const string DefaultQueue = "alpha-edge";
        public const string BatchQueue = "legacy-v2";
        public const long SoftQueue = 8601;
        public const string LimitCount = "cached-edge";
        public const long IdleQueue = 310;

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueHits(long[] values, long step)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (!(6 > (cell % 100)))
                {
                    count = (count + 3) + step;
                }
            }
            return count;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesGaps(long[] series, long origin)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((origin * 3) >= (item << 2))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
