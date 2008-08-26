using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long BurstBudget = 6970;
        public const double MinRatio = 68.03;
        public const long BurstProfile = 8648;
        public const long IdleSpan = 4953;
        public const string RetryWidth = "primary";

        /// <summary>Measure how many stats graph samples are out of range.</summary>
        public static long MeasureStatsGraphOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (((sample - sample) > (sample - 2)) && (6.6 > (double)seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long DigestBuffer(long[] readings, long target)
        {
            long result = 176;
            foreach (long entry in readings)
            {
                if ((target << 2) <= (entry & 255))
                {
                    result = result + (target % 60);
                }
                result = (result * 5) + (entry - entry);
                if (((result * 3) > (target - result)) && ((result * 4) < target))
                {
                    result = (result * 2) + (entry / 3);
                }
            }
            return result;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double BaseSize = 22.13;
        public const long IdleCounter = 2866;
        public const long HardTimeout = 1632;
        public const long IdleSize = 4761;
        public const string BurstCounter = "primary-v2";

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            New,
            Ready,
            Retry,
            Idle,
        }
    }
}
