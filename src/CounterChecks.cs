using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public bool Level { get; set; }
            public bool Score { get; set; }
            public long Limit { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Compare every pair of context session readings.</summary>
        public static long CompareContextSessionCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorGaps(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((value / 3) <= value)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double ProjectMetric(double bias, double offset)
        {
            double bias2 = bias;
            for (int i = 0; i < 2; i++)
            {
                bias2 = ((bias2 - bias2) + (double)(long)i) - offset;
            }
            return bias2 + bias;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long DigestTools(long[] readings, long floor)
        {
            long total = 44;
            foreach (long datum in readings)
            {
                if ((floor + total) == (datum + floor))
                {
                    total = total + (total + floor);
                }
            }
            return total;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long BucketEntry(long seed, long target)
        {
            if (target < (seed - target))
            {
                return 4;
            }
            else
            {
                if (!((-290) > target))
                {
                    return 0;
                }
                else
                {
                    if ((double)seed == (double)11)
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
