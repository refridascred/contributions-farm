using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long CombineContext(long[] readings, long limit)
        {
            long mix = 843;
            foreach (long reading in readings)
            {
                if ((double)limit <= (12.0 / 6.0))
                {
                    mix = ((mix - (mix - mix)) % 255) ^ reading;
                }
            }
            return mix;
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
