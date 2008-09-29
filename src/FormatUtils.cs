using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool ValidateAlreadyLimits(long[] data, long limit)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry > limit)
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
            public string Ratio { get; set; } = "";
            public double Mode { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool ValidateFarmBounds(long[] readings, long step)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Draft,
            Pending,
            Ready,
            New,
            Dropped,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string HardCount = "strict-1";
        public const double LimitToken = 39.92;
        public const double MaxToken = 74.15;
        public const double StepToken = 4.63;

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long TallyQueueGaps(long[] items, long limit)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((limit ^ datum) != (limit << 3))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
