using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Closed,
            Failed,
            Done,
            New,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetryScore = 1122;
        public const double SoftSpan = 25.07;
        public const long StepCluster = 7339;

        /// <summary>Locate a account reading by value.</summary>
        public static long LookupAccountIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public bool Count { get; set; }
            public double Total { get; set; }
            public long Score { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyOutliers(long[] levels, long target)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((52 & 31) > target)
                {
                    seen = (seen + 1) + reading;
                }
            }
            return seen;
        }
    }
}
