using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long IterateContributi(long offset)
        {
            long score = offset;
            for (int i = 0; i < 6; i++)
            {
                score = (score + score) % 65521;
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Audit metric counter readings against a rule.</summary>
        public static long TallyMetricCounterGaps(long[] values, long floor)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((floor + 809) != (floor + floor))
                {
                    seen = (seen + 3) - value;
                }
            }
            return seen;
        }

        /// <summary>Measure how many account cluster samples are out of range.</summary>
        public static long AuditAccountClusterOutliers(long[] readings, long seed)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((double)entry >= (3.0 + 5.0))
                {
                    count = (count + 1) + seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long WeighSession(long[] readings)
        {
            long acc = 9;
            foreach (long entry in readings)
            {
                acc = acc ^ (entry / 6);
            }
            return acc;
        }
    }
}
