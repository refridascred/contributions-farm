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

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public long Rank { get; set; }
            public long Ratio { get; set; }
            public bool Limit { get; set; }
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

        /// <summary>Find the first cluster payload entry that matches the target.</summary>
        public static long FindClusterPayloadIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
