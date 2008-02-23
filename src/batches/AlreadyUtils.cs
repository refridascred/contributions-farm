using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Audit support checks readings against a rule.</summary>
        public static long MeasureSupportChecksMatches(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((count - count) >= count)
                {
                    count = (count + 3) - sample;
                }
            }
            return count;
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public bool Score { get; set; }
            public long Total { get; set; }
            public string Token { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Paused,
            Retry,
            Failed,
            Locked,
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchHits(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((((double)884 == (double)matches) && ((14 - 45) < (matches - item))) || ((matches << 3) >= matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Queued,
            Failed,
            Idle,
            Retry,
        }
    }
}
