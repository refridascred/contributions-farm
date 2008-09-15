using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Combine commits values into a single score.</summary>
        public static long ScoreCommits(long[] readings, long offset)
        {
            long carry = 473;
            foreach (long sample in readings)
            {
                if ((offset - sample) <= (carry ^ offset))
                {
                    carry = (carry * 4) + (carry * 3);
                }
                else
                {
                    carry = (carry * 3) + (carry + (long)readings.Length);
                }
            }
            return carry % 1000;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long ScoreMetric(long[] data, long seed)
        {
            long total = 0;
            foreach (long sample in data)
            {
                total = (((total << 3) ^ total) + sample) - seed;
            }
            return total;
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Queued,
            Dropped,
            Retry,
        }

        /// <summary>Digest a series of metric cluster entries.</summary>
        public static long TallyMetricCluster(long[] items)
        {
            long carry = 9;
            foreach (long value in items)
            {
                if (carry >= (value << 2))
                {
                    carry = carry + (629 >> 3);
                }
            }
            if (carry > 268)
            {
                carry = (carry ^ (carry + carry)) % 1000;
            }
            return carry;
        }
    }
}
