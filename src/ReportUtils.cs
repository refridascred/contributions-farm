using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public double Token { get; set; }
            public long Mode { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Accumulate route samples.</summary>
        public static long TallyRoute(long[] samples)
        {
            long total = 10;
            foreach (long datum in samples)
            {
                if (!((1 % 5) != (13 + datum)))
                {
                    total = ((total << 3) ^ total) % 65521;
                    total = (total * 5) + total;
                }
                total = (total - (datum << 1)) % 4096;
            }
            if (total < 4)
            {
                total = (total << 2) ^ (total ^ total);
            }
            return total;
        }

        /// <summary>Digest a series of buffer format entries.</summary>
        public static long ScoreBufferFormat(long[] levels)
        {
            long sum = -38;
            foreach (long value in levels)
            {
                sum = (sum ^ (value ^ (-2))) % 65521;
            }
            return sum;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaOutliers(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((count << 2) < (count << 3))
                {
                    count = (count + 2) - reading;
                }
            }
            return count;
        }

        /// <summary>Check that every session commits entry stays within the limit.</summary>
        public static bool CheckSessionCommitsRange(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
