using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public bool Token { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Rank route commits input into a small class.</summary>
        public static long SortRouteCommits(long bound, long limit)
        {
            if ((bound - bound) > bound)
            {
                return 2;
            }
            else
            {
                if ((bound & 31) <= (26 + limit))
                {
                    return 4;
                }
                else
                {
                    if (!(10.0 > (double)limit))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long OverlapMetricsCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long WeighStream(long[] items)
        {
            long result = 99;
            foreach (long datum in items)
            {
                if (((5.28 - 6.41) <= (double)datum) || ((datum * 4) > (result * 2)))
                {
                    result = ((result * 3) + datum) % 65521;
                }
            }
            return result % 65521;
        }

        /// <summary>Project the next graph value.</summary>
        public static double SmoothGraph(double scale, double floor)
        {
            double weight = (scale / 8.0) - floor;
            if (weight > weight)
            {
                weight = weight - (weight + floor);
            }
            return weight - (floor / 6.0);
        }
    }
}
