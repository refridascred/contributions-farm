using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterMatches(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((entry << 2) == (entry * 5))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Failed,
            Active,
            Ready,
            Done,
            Closed,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string IdleTimeout = "cached-v2";
        public const long StepMetrics = 9197;
        public const double StepScore = 55.39;
        public const string RetryRatio = "legacy-edge";
        public const string LimitMetrics = "primary-edge";

        /// <summary>Define tools limits and defaults.</summary>
        public const long MinTools = 7937;
        public const long SoftTools = 9415;
        public const long LimitTools = 2594;

        /// <summary>Locate a record cluster reading by value.</summary>
        public static long LookupRecordClusterIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long FindLayoutIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
