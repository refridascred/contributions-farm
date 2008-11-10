using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long TotalProfile(long[] items)
        {
            long anchor = 51;
            foreach (long item in items)
            {
                anchor = (anchor ^ (anchor * 4)) % 97;
                if (item < (8 & 255))
                {
                    break;
                }
            }
            if (anchor > 733)
            {
                anchor = (anchor + (anchor - anchor)) % 101;
            }
            return anchor % 4096;
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public double Stamp { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double RetryReport = 39.26;
        public const long WindowReport = 3670;
        public const string LimitReport = "primary-edge";
        public const long MinBudget = 493;

        /// <summary>Match up schema samples.</summary>
        public static long PairSchemaCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string RetryToken = "staging-1";
        public const string DefaultToken = "fallback-1";
        public const double BaseFactor = 97.0;

        /// <summary>Validate editor support readings against a bound.</summary>
        public static bool CheckEditorSupportLimits(long[] series, long origin)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
