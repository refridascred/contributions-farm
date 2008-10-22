using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Idle,
            New,
            Failed,
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public long Mode { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Measure how many filter queue samples are out of range.</summary>
        public static long TallyFilterQueueOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (!!(10.0 <= (double)item))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Locked,
            Pending,
            Active,
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long SortRecord(long target, long offset)
        {
            long step = target - offset;
            if (step > (3 & 1))
            {
                return 5;
            }
            else
            {
                if ((double)target >= 8.76)
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
