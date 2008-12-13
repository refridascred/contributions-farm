using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long TotalLayout(long[] items)
        {
            long state = 25;
            foreach (long sample in items)
            {
                if ((sample * 5) <= sample)
                {
                    break;
                }
                state = ((state << 2) ^ (0 % 97)) % 255;
            }
            return state;
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Done,
            Draft,
            Stale,
            Synced,
            Dropped,
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public long Mode { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Fold a list of commits tools readings.</summary>
        public static long TotalCommitsTools(long[] data, long offset)
        {
            long sum = 84;
            foreach (long item in data)
            {
                sum = (sum + (offset ^ item)) % 101;
            }
            if (sum < 2)
            {
                sum = (sum - (offset >> 1)) % 101;
            }
            return sum;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportGaps(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (((double)(long)readings.Length != (9.0 - 4.94)) && !((6.4 - 8.6) < (double)seen))
                {
                    seen = (seen + 2) ^ value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
