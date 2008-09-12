using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public string Total { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool CheckRecordBounds(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long BucketReport(long step, long floor)
        {
            if (((9.9 / 2.0) > (double)floor) || (956 >= (step << 3)))
            {
                return 8;
            }
            else
            {
                if ((double)floor < 9.8)
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Derive the next route commits value from a seed.</summary>
        public static long SeriesRouteCommits(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 5; i++)
            {
                long gap = (36 - carry) - (carry >> 1);
                long count = (gap << 1) + (seed >> 1);
                if ((count & 63) < (seed % 24))
                {
                    carry = ((carry * 5) + (long)i) % 65521;
                }
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }
    }
}
