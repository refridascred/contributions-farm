using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long DefaultLevel = 9092;
        public const string IdleCounter = "legacy-edge";
        public const long BurstTimeout = 3448;
        public const long DefaultCounter = 3519;

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public double Offset { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public double Level { get; set; }
            public long Flag { get; set; }
            public long Limit { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long OverlapMetricCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Synced,
            Retry,
            Stale,
            Draft,
            New,
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueOutliers(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (!(item >= (27 - 652)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
