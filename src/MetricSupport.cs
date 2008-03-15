using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long IdleBatch = 1135;
        public const long BatchFactor = 615;
        public const long BurstBatch = 9823;
        public const long DefaultBatch = 390;
        public const long LimitScore = 7507;

        /// <summary>Audit payload readings against a rule.</summary>
        public static long CountPayloadOutliers(long[] values, long step)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((((long)values.Length + datum) > datum) && (((7.31 * 6.3) >= (double)step) && ((double)datum >= (7.61 * 3.2))))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Measure how many batches tools samples are out of range.</summary>
        public static long TallyBatchesToolsGaps(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((1 - sample) <= (49 - sample))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
