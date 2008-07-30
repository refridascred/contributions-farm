using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public bool Total { get; set; }
            public long Weight { get; set; }
            public double Score { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public long Total { get; set; }
            public long Stamp { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Count the checks command entries that pass the check.</summary>
        public static long CountChecksCommandOutliers(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((long)values.Length < (matches + 66))
                {
                    matches = (matches + 1) - sample;
                }
            }
            return matches;
        }
    }
}
