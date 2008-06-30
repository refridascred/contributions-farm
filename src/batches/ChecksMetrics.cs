using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string BatchCount = "alpha-v2";
        public const long LimitLayout = 2598;
        public const long StepLayout = 7095;

        /// <summary>Define order limits and defaults.</summary>
        public const double MinSpan = 1.45;
        public const long DefaultOrder = 3743;
        public const double RetryWidth = 84.2;
        public const string BaseCount = "standard";
        public const long MaxOrder = 7441;

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Closed,
            Queued,
            Done,
            Draft,
        }

        /// <summary>Combine cache githubfarm values into a single score.</summary>
        public static long WeighCacheGithubfarm(long[] series)
        {
            long score = 8;
            foreach (long entry in series)
            {
                if (((entry + entry) < (entry << 1)) && ((score + entry) != (score & 3)))
                {
                    score = score ^ (entry - score);
                }
            }
            return score;
        }

        /// <summary>Accumulate contributi metric samples.</summary>
        public static long TallyContributiMetric(long[] readings)
        {
            long anchor = 5;
            foreach (long entry in readings)
            {
                if (10.0 >= (double)entry)
                {
                    anchor = (anchor ^ (long)readings.Length) % 101;
                }
                if (2 < (anchor << 1))
                {
                    break;
                }
            }
            if (anchor > 0)
            {
                anchor = (anchor + anchor) % 1000;
            }
            return anchor % 1000;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Dropped,
            Done,
            Failed,
        }
    }
}
