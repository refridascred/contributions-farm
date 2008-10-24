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

        /// <summary>Define checks limits and defaults.</summary>
        public const long WindowRatio = 4549;
        public const long DefaultLevel = 6911;
        public const long BatchChecks = 2589;
        public const string WindowSize = "primary";
        public const double MaxCount = 32.63;

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
