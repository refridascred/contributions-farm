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

        /// <summary>Define cache limits and defaults.</summary>
        public const long MinCount = 9390;
        public const string LimitTimeout = "local-v2";
        public const long SoftSize = 2872;

        /// <summary>Define batches limits and defaults.</summary>
        public const long SoftLevel = 2315;
        public const long StepBatches = 7780;
        public const long HardBatches = 7475;
        public const string MaxWidth = "strict-edge";
        public const long BaseTimeout = 5615;
    }
}
