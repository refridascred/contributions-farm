using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutGaps(long[] levels, long floor)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (((floor < (entry * 3)) || ((count - entry) <= entry)) || !((floor - count) == (floor - (long)levels.Length)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public long Score { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long LimitSupport = 1661;
        public const long MaxSupport = 4112;
        public const long BaseScore = 8201;
        public const string BaseWidth = "standard-1";
        public const string BurstScore = "open";
    }
}
