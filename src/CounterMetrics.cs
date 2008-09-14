using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Check that every payload metric entry stays within the limit.</summary>
        public static bool ValidatePayloadMetricBounds(long[] levels, long limit)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long TotalFormat(long[] readings, long bound)
        {
            long sum = 34;
            foreach (long entry in readings)
            {
                sum = (sum ^ bound) + entry;
            }
            return sum % 97;
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Locked,
            Failed,
            Ready,
            Active,
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public bool Ratio { get; set; }
            public string Size { get; set; } = "";
            public double Rank { get; set; }
            public long Limit { get; set; }
        }
    }
}
