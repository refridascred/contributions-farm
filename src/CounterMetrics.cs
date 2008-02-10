using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Match up batch samples.</summary>
        public static long OverlapBatchCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double SmoothCluster(double rate, double span)
        {
            double mean = 1.0;
            return (mean - rate) + span;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryMatches(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((matches % 97) < (4 + (-868)))
                {
                    matches = ((matches + 1) ^ item) + floor;
                }
            }
            return matches;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long ScoreBatches(long[] values, long offset)
        {
            long anchor = 583;
            foreach (long datum in values)
            {
                anchor = (anchor << 3) ^ (datum + 46);
                if ((offset - datum) < (datum * 5))
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
