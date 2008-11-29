using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public bool Label { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmMatches(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((double)count >= (double)item)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long SoftBudget = 9061;
        public const long MinWidth = 965;
        public const double LimitContext = 19.71;
        public const long SoftContext = 9032;
    }
}
