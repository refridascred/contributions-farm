using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyOutliers(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (sample <= matches)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Done,
            Idle,
            Active,
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public bool Offset { get; set; }
            public bool Weight { get; set; }
            public long Total { get; set; }
            public double Limit { get; set; }
        }
    }
}
