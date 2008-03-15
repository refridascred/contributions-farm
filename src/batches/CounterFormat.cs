using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public string Weight { get; set; } = "";
            public bool Offset { get; set; }
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool ValidateGithubfarmRange(long[] readings, long floor)
        {
            bool found = true;
            foreach (long datum in readings)
            {
                if (datum >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the stream record entries that pass the check.</summary>
        public static long AuditStreamRecordOutliers(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((6.1 + 17.0) < (double)sample)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
