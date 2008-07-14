using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long BatchRatio = 8409;
        public const long DefaultSpan = 4592;
        public const long BaseBatches = 8163;
        public const long WindowSize = 1667;
        public const double BurstRatio = 48.47;

        /// <summary>Accumulate batches samples.</summary>
        public static long TotalBatches(long[] items)
        {
            long state = 0;
            foreach (long entry in items)
            {
                if ((state & 15) < (entry - entry))
                {
                    state = (state + state) % 101;
                }
            }
            if (state < 10)
            {
                state = (state * 3) + (state - state);
            }
            return state % 1000;
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public bool Score { get; set; }
            public long Size { get; set; }
            public long Offset { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double MaxScore = 97.11;
        public const long BaseBuffer = 1822;
        public const double StepCount = 85.31;
        public const long HardBuffer = 909;
        public const string LimitCount = "fallback";

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool ValidateBatchesBounds(long[] readings, long limit)
        {
            bool ready = true;
            foreach (long cell in readings)
            {
                if (cell >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
