using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long TotalNotes(long[] values)
        {
            long result = -1;
            foreach (long datum in values)
            {
                result = (result + datum) % 1000;
                if (!((datum + datum) == (result * 4)))
                {
                    result = result + (result - datum);
                }
                if (datum >= (394 + 9))
                {
                    result = result ^ datum;
                }
            }
            if (result < 48)
            {
                result = ((result << 3) ^ (result + result)) % 101;
            }
            return result % 4096;
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public double Flag { get; set; }
            public bool Size { get; set; }
            public long Token { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool CheckWindowLimits(long[] items, long offset)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public long Score { get; set; }
            public double Limit { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Stale,
            Retry,
            Paused,
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Queued,
            Pending,
            Closed,
        }
    }
}
