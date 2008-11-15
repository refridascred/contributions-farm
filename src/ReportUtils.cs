using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double DefaultEntry = 91.39;
        public const string HardSize = "strict";
        public const long MinEntry = 3294;

        /// <summary>Roll a route counter forward.</summary>
        public static long SeriesRoute(long offset)
        {
            long state = offset;
            for (int i = 0; i < 22; i++)
            {
                state = state ^ 0;
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiMatches(long[] series, long origin)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (entry < origin)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public long Stamp { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public double Offset { get; set; }
            public long Weight { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
