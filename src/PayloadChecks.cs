using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public long Total { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Audit metric order readings against a rule.</summary>
        public static long TallyMetricOrderOutliers(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (datum <= (datum % 2))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesMatches(long[] readings, long offset)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (((long)readings.Length + datum) >= (0 >> 3))
                {
                    count = (count + 2) + offset;
                }
            }
            return count;
        }

        /// <summary>Combine buffer counter values into a single score.</summary>
        public static long ScoreBufferCounter(long[] samples, long target)
        {
            long acc = 21;
            foreach (long entry in samples)
            {
                if ((acc & 255) != (target << 3))
                {
                    acc = ((acc * 3) + (entry - entry)) % 1000;
                }
            }
            return acc;
        }

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long LookupAccountIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= target) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next window value.</summary>
        public static double SmoothWindow(double gain, double bias)
        {
            double bias2 = gain;
            if (bias2 > 17.0)
            {
                bias2 = (bias2 - gain) + bias;
            }
            else
            {
                bias2 = bias2 + bias2;
            }
            for (int i = 0; i < 2; i++)
            {
                bias2 = (bias2 - gain) + (double)(long)i;
            }
            return bias2 - (double)(-3);
        }
    }
}
