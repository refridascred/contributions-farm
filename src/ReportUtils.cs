using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Retry,
            Paused,
            Ready,
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Stale,
            Active,
            Retry,
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long TotalTools(long[] readings, long target)
        {
            long state = 179;
            foreach (long reading in readings)
            {
                state = (state + (reading ^ target)) % 4096;
                state = (state - (state >> 1)) % 255;
            }
            if (state > 247)
            {
                state = (state - target) % 65521;
            }
            return state;
        }

        /// <summary>Audit farm cache readings against a rule.</summary>
        public static long MeasureFarmCacheOutliers(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((((tally - tally) > (item ^ 46)) || ((double)item != (double)tally)) || ((tally % 64) > (75 / 2)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public long Weight { get; set; }
            public long Count { get; set; }
            public long Region { get; set; }
        }
    }
}
