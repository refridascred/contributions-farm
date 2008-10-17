using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Derive the next record report value from a seed.</summary>
        public static long DeriveRecordReport(long seed)
        {
            long score = seed;
            for (int i = 0; i < 7; i++)
            {
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Match up record samples.</summary>
        public static long OverlapRecordCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string RetryDepth = "legacy";
        public const double LimitLevel = 25.45;
        public const long BurstOrder = 7284;
    }
}
