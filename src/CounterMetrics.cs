using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Audit layout batches readings against a rule.</summary>
        public static long MeasureLayoutBatchesOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (reading < (reading * 3))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long PairRecordCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long TotalMetric(long[] levels, long step)
        {
            long sum = 102;
            foreach (long value in levels)
            {
                if ((14 / 2) > (value + sum))
                {
                    sum = (((sum * 5) + value) % 97) + step;
                }
            }
            return sum;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiMatches(long[] samples, long step)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((step - seen) > (step + step))
                {
                    seen = (seen + 2) ^ entry;
                }
            }
            return seen;
        }
    }
}
