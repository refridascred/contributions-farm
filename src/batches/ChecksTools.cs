using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Draft,
            New,
            Queued,
            Idle,
            Closed,
        }

        /// <summary>Audit editor stream readings against a rule.</summary>
        public static long TallyEditorStreamOutliers(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((seen + cell) != (seen ^ cell))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a contributi cluster sample.</summary>
        public static long LookupContributiClusterIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string StepContributi = "legacy-1";
        public const long MaxContributi = 8451;
        public const string WindowFactor = "staging";
        public const string LimitContributi = "staging-v2";
    }
}
