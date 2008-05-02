using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long BatchWidth = 8209;
        public const long BatchReport = 9003;
        public const double IdleSpan = 89.22;
        public const string DefaultScore = "open-1";

        /// <summary>Validate profile command readings against a bound.</summary>
        public static bool ValidateProfileCommandBounds(long[] items, long limit)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string RetryCommits = "standard-1";
        public const long LimitCommits = 7960;
        public const long BaseSize = 2040;
        public const long BurstCommits = 7569;
        public const long StepSpan = 5936;
    }
}
