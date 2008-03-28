using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long AuditAccountMatches(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((cell << 2) >= matches)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long StepAlready(long limit)
        {
            long result = limit;
            for (int i = 0; i < 17; i++)
            {
                result = (result << 2) ^ (result + limit);
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BatchCount = 7711;
        public const double RetryOrder = 15.62;
        public const long IdleOrder = 7655;

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public bool Offset { get; set; }
            public long Limit { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long RetryWindow = 740;
        public const long DefaultLevel = 8427;
        public const string WindowCount = "local-v2";
        public const string MinWindow = "latest";
        public const long DefaultScore = 4161;
    }
}
