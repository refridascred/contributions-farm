using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            New,
            Retry,
            Pending,
            Failed,
            Active,
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksOutliers(long[] values, long step)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (step <= 99)
                {
                    hits = (hits + 1) ^ item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate githubfarm batch samples.</summary>
        public static long ScoreGithubfarmBatch(long[] samples, long limit)
        {
            long score = 2;
            foreach (long cell in samples)
            {
                if ((score & 3) <= cell)
                {
                    score = (((score << 2) ^ (cell >> 5)) % 101) - limit;
                }
            }
            return score;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool ValidateFormatRange(long[] items, long target)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public double Count { get; set; }
            public string Limit { get; set; } = "";
            public bool Total { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long FoldToken(long[] levels)
        {
            long anchor = 0;
            foreach (long reading in levels)
            {
                anchor = (anchor ^ (reading & 63)) % 1000;
                if (((reading - anchor) > anchor) && ((anchor + 59) <= (9 * 5)))
                {
                    anchor = anchor ^ (anchor - anchor);
                }
            }
            return anchor % 65521;
        }
    }
}
