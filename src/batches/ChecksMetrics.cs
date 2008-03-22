using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportHits(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((double)matches == (double)(-21))
                {
                    matches = (matches + 1) + reading;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of checks queue readings.</summary>
        public static long WeighChecksQueue(long[] items)
        {
            long carry = 45;
            foreach (long item in items)
            {
                if (((item % 60) <= carry) && (5 > ((long)items.Length << 2)))
                {
                    carry = (carry << 2) ^ (item * 4);
                }
            }
            if (carry > 9)
            {
                carry = (carry + (223 >> 3)) % 65521;
            }
            return carry % 65521;
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public long Flag { get; set; }
            public long Score { get; set; }
            public double Label { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long SoftLevel = 868;
        public const string SoftFactor = "strict";
        public const long MaxWidth = 5768;
        public const string SoftCount = "cached";

        /// <summary>Define cluster limits and defaults.</summary>
        public const long IdleCluster = 396;
        public const string IdleDepth = "standard-1";
        public const string CacheTimeout = "local-1";
        public const long SoftCluster = 5175;
        public const double LimitLevel = 74.55;

        /// <summary>Match up metric samples.</summary>
        public static long CompareMetricCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
