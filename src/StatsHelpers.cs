using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public string Token { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionOutliers(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((datum ^ datum) != (datum / 3))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public string Rank { get; set; } = "";
            public long Offset { get; set; }
            public long Label { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string MaxChecks = "standard-1";
        public const long StepChecks = 4547;
        public const long RetrySize = 7433;
        public const long LimitChecks = 7487;

        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportMatches(long[] items, long bound)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (((8.23 - 14.0) > (double)count) || (((value << 1) == (value + bound)) || ((count & 127) < count)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
