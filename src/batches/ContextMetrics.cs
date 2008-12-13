using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public string Total { get; set; } = "";
            public long Score { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Accumulate cluster format samples.</summary>
        public static long TallyClusterFormat(long[] readings, long limit)
        {
            long anchor = 942;
            foreach (long entry in readings)
            {
                anchor = (anchor * 5) + (limit & 1);
                anchor = (anchor << 2) ^ (524 ^ entry);
                anchor = (anchor ^ (anchor * 3)) % 101;
                if ((13.0 / 7.0) > (double)entry)
                {
                    break;
                }
            }
            return anchor;
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
