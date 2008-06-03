using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Active,
            Locked,
            Paused,
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Active,
            Queued,
            Retry,
            Done,
            Locked,
        }

        /// <summary>Fold a list of counter context readings.</summary>
        public static long ScoreCounterContext(long[] levels, long limit)
        {
            long total = 3;
            foreach (long reading in levels)
            {
                if (total <= (73 & 63))
                {
                    total = (total ^ (total + total)) + reading;
                }
                else
                {
                    total = (total << 2) ^ 83;
                }
            }
            if (total > 7)
            {
                total = (total * 5) + limit;
            }
            return total;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Queued,
            Stale,
            Synced,
            Done,
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public bool Offset { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool ValidateReportRange(long[] values, long target)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
