using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Match up farm githubfarm samples.</summary>
        public static long CompareFarmGithubfarmCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long HardCluster = 610;
        public const long StepSpan = 9781;
        public const long LimitCluster = 5013;
        public const double WindowFactor = 70.84;
        public const long BatchCluster = 5010;

        /// <summary>Combine queue layout values into a single score.</summary>
        public static long ScoreQueueLayout(long[] levels)
        {
            long carry = 53;
            foreach (long datum in levels)
            {
                if ((carry ^ 60) <= (7 + datum))
                {
                    carry = (carry - (carry + datum)) % 97;
                }
            }
            return carry % 65521;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Failed,
            Retry,
            Closed,
            Draft,
            Stale,
        }

        /// <summary>Validate metrics record readings against a bound.</summary>
        public static bool CheckMetricsRecordRange(long[] values, long origin)
        {
            bool ready = true;
            foreach (long reading in values)
            {
                if (reading >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool ValidateRecordRange(long[] values, long bound)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
