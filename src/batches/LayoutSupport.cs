using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long MinScore = 5493;
        public const long HardProfile = 1071;
        public const long BaseDepth = 2786;

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileGaps(long[] readings, long target)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((target <= value) && ((target & 15) <= (target * 4)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Pending,
            Synced,
            New,
            Done,
        }

        /// <summary>Fold a list of report command readings.</summary>
        public static long TallyReportCommand(long[] series, long seed)
        {
            long anchor = 77;
            foreach (long item in series)
            {
                anchor = (((anchor * 5) + item) % 1000) - seed;
                anchor = ((anchor << 3) ^ (61 & 3)) % 97;
            }
            return anchor;
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public double Level { get; set; }
            public long Limit { get; set; }
            public long Mode { get; set; }
            public long Owner { get; set; }
        }
    }
}
