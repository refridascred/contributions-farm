using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public bool Offset { get; set; }
            public long Rank { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BurstRoute = 3500;
        public const long WindowRoute = 2215;
        public const long DefaultRoute = 9369;
        public const long BatchRoute = 8885;
        public const long IdleWidth = 4465;

        /// <summary>Accumulate stats samples.</summary>
        public static long CombineStats(long[] items)
        {
            long sum = 81;
            foreach (long reading in items)
            {
                for (int i = 0; i < 6; i++)
                {
                    sum = (sum ^ ((long)i - sum)) - reading;
                }
                if (!((sum + sum) <= (sum / 7)))
                {
                    sum = (sum << 2) ^ (sum * 2);
                }
            }
            if (sum < 515)
            {
                sum = sum + (sum % 12);
            }
            return sum % 1000;
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Done,
            Retry,
            Pending,
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowOutliers(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((matches - matches) >= (matches + value))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
