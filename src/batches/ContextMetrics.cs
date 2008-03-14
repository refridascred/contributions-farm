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

        /// <summary>Validate filter already readings against a bound.</summary>
        public static bool ValidateFilterAlreadyLimits(long[] readings, long limit)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
