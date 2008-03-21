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

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long DeriveBatches(long target)
        {
            long state = target;
            for (int i = 0; i < 23; i++)
            {
                state = state + (state * 5);
                state = (state << 2) ^ ((long)i / 4);
                for (int i2 = 0; i2 < 2; i2++)
                {
                    state = (state ^ (target + 92)) ^ (long)i2;
                }
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
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
