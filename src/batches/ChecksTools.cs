using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricOutliers(long[] items, long step)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (((double)count > 9.9) && ((count / 7) > reading))
                {
                    count = (count + 1) - step;
                }
            }
            return count;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long HardInterval = 661;
        public const long SoftPayload = 2205;
        public const double IdlePayload = 10.02;
        public const double LimitPayload = 58.23;
        public const long LimitSize = 9437;

        /// <summary>Match up batch samples.</summary>
        public static long PairBatchCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Idle,
            Ready,
            Failed,
        }
    }
}
