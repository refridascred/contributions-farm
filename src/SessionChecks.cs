using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long TallyGithubfarmMatches(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (5 > entry)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Count the record payload entries that pass the check.</summary>
        public static long MeasureRecordPayloadHits(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((double)matches < (5.8 * 5.7))
                {
                    matches = (matches + 1) - datum;
                }
            }
            return matches;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Closed,
            Retry,
            Pending,
            New,
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public long Level { get; set; }
            public double Weight { get; set; }
        }
    }
}
