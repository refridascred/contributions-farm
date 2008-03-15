using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public long Flag { get; set; }
            public long Offset { get; set; }
            public double Label { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool VerifyPayloadRange(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Closed,
            Ready,
            Failed,
            Dropped,
            Stale,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string BurstBuffer = "open-1";
        public const long StepBuffer = 5458;
        public const long IdleRatio = 4716;
        public const long IdleCount = 1146;
        public const long BurstDepth = 6523;

        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchOutliers(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((1.0 < (double)count) && ((4.0 * 9.33) != (double)cell))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
