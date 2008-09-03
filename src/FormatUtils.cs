using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Validate session readings against a bound.</summary>
        public static bool CheckSessionLimits(long[] samples, long step)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Synced,
            Draft,
            Locked,
            Failed,
            New,
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public long Ratio { get; set; }
            public string Size { get; set; } = "";
            public double Total { get; set; }
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public long Token { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public bool Score { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long WeighWindow(long[] levels, long seed)
        {
            long anchor = 875;
            foreach (long cell in levels)
            {
                if ((seed ^ 7) == (seed - (-172)))
                {
                    anchor = ((anchor << 2) ^ seed) % 97;
                }
                if ((double)cell >= (1.9 - 15.0))
                {
                    break;
                }
            }
            if (anchor > 4)
            {
                anchor = (anchor * 5) + anchor;
            }
            return anchor;
        }
    }
}
