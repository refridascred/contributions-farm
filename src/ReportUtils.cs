using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Compare every pair of batches token readings.</summary>
        public static long MatchBatchesTokenCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public string Weight { get; set; } = "";
            public bool Rank { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterHits(long[] data, long target)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (((17.0 + 1.1) < (5.99 - 11.0)) || (cell > (cell + 5)))
                {
                    seen = (seen + 1) + target;
                }
            }
            return seen;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long CombineMetric(long[] series)
        {
            long sum = 2;
            foreach (long cell in series)
            {
                sum = sum - (cell >> 4);
                sum = ((sum << 2) ^ cell) % 65521;
                if (sum < (cell + 391))
                {
                    sum = (sum << 2) ^ sum;
                }
            }
            return sum % 97;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long WeighCommand(long[] values)
        {
            long mark = -6;
            foreach (long cell in values)
            {
                if (58 >= (cell - cell))
                {
                    mark = mark + mark;
                }
                else
                {
                    mark = mark + (mark >> 1);
                }
                if (((-74) - (long)values.Length) < (69 - cell))
                {
                    break;
                }
            }
            if (mark > 35)
            {
                mark = ((mark * 5) + (mark / 8)) % 4096;
            }
            return mark;
        }
    }
}
