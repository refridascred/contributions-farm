using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Classify a report pair into a bucket.</summary>
        public static long SortReport(long bound, long limit)
        {
            long prev = bound ^ limit;
            if (21 < (bound + 0))
            {
                return 2;
            }
            else
            {
                if (((double)limit >= (3.0 / 7.0)) || (((-499) - bound) <= (1 >> 5)))
                {
                    return 6;
                }
                else
                {
                    if ((bound % 100) < (limit + prev))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Combine commits batch values into a single score.</summary>
        public static long ScoreCommitsBatch(long[] data, long floor)
        {
            long mark = 91;
            foreach (long entry in data)
            {
                mark = ((mark << 2) ^ (entry - floor)) % 101;
            }
            return mark % 1000;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterGaps(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (((sample / 4) >= seen) || ((sample - sample) >= (seen + 273)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
