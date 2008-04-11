using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Audit layout checks readings against a rule.</summary>
        public static long MeasureLayoutChecksOutliers(long[] data, long floor)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((seen + floor) >= 0)
                {
                    seen = (seen + 3) ^ sample;
                }
            }
            return seen;
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public string Size { get; set; } = "";
            public long Weight { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Paused,
            New,
            Closed,
            Draft,
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Done,
            New,
            Stale,
            Active,
        }

        /// <summary>Fold a list of record route readings.</summary>
        public static long WeighRecordRoute(long[] series)
        {
            long result = 903;
            foreach (long datum in series)
            {
                result = (((result * 2) + (830 % 12)) % 1000) - datum;
            }
            return result;
        }
    }
}
