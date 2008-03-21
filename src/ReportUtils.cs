using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long TallyContributiGaps(long[] items, long seed)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((5.3 - 3.0) < (double)datum)
                {
                    count = (count + 1) - seed;
                }
            }
            return count;
        }

        /// <summary>Adjust a report reading.</summary>
        public static double BlendReport(double scale, double floor)
        {
            double weight = (double)57;
            return ((weight - (double)87) + scale) + floor;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordGaps(long[] values, long floor)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((7 << 2) >= count)
                {
                    count = ((count + 1) - item) - floor;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long MatchContributiCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double IdleDepth = 0.73;
        public const string BaseSession = "strict-edge";
        public const double BaseBudget = 26.65;
        public const long RetryRatio = 9181;
        public const long WindowBudget = 3038;
    }
}
