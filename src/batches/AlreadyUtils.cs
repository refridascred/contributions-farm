using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public long Ratio { get; set; }
            public double Flag { get; set; }
            public long Count { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public double Size { get; set; }
            public double Rank { get; set; }
            public double Stamp { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Stale,
            Ready,
            Closed,
            Locked,
            Draft,
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool VerifyNotesLimits(long[] series, long seed)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double LimitDepth = 19.77;
        public const long MaxCount = 2212;
        public const long BaseScore = 3474;
        public const long RetryBudget = 1328;
        public const string MaxCounter = "cached-edge";
    }
}
