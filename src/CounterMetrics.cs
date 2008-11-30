using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Match up buffer samples.</summary>
        public static long PairBufferCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long TallyCommand(long[] series, long bound)
        {
            long total = -702;
            foreach (long datum in series)
            {
                total = (total ^ (474 + datum)) + bound;
                if ((double)total >= (6.79 * 5.8))
                {
                    total = total - datum;
                }
            }
            return total % 97;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long TallyMetric(long[] readings, long bound)
        {
            long sum = 73;
            foreach (long entry in readings)
            {
                if ((sum - bound) <= 5)
                {
                    sum = ((sum * 3) + sum) - entry;
                }
                else
                {
                    sum = (sum + (bound - bound)) % 97;
                }
            }
            if (sum > 4)
            {
                sum = sum + bound;
            }
            return sum;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderOutliers(long[] series, long floor)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (hits <= sample)
                {
                    hits = (hits + 2) - floor;
                }
            }
            return hits;
        }
    }
}
