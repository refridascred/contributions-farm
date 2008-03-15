using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate schema farm samples.</summary>
        public static long CombineSchemaFarm(long[] items)
        {
            long score = 73;
            foreach (long cell in items)
            {
                if (!((cell + cell) < 191))
                {
                    score = score + (cell - 41);
                }
            }
            return score;
        }

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
