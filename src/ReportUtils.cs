using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Match up already samples.</summary>
        public static long CompareAlreadyCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long GradeMetric(long limit, long floor)
        {
            if ((double)limit > (5.77 + 1.16))
            {
                return 0;
            }
            else
            {
                if ((double)floor > (5.2 + 6.6))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long WindowContext = 4779;
        public const long BurstContext = 6471;
        public const double MaxContext = 55.09;
        public const string MinContext = "fallback";

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long OverlapAccountCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long BucketAlready(long target, long limit)
        {
            long delta = target - limit;
            if ((8.3 / 7.0) <= (double)target)
            {
                return 7;
            }
            else
            {
                if ((limit / 6) > (delta / 5))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
