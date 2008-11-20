using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Measure how many token batch samples are out of range.</summary>
        public static long CountTokenBatchOutliers(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((139 + count) < (reading << 3))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long CountContributiGaps(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (cell >= matches)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public string Owner { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            New,
            Paused,
            Draft,
        }
    }
}
