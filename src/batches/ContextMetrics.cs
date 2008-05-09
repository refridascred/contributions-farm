using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Draft,
            Active,
            Retry,
            Queued,
            Pending,
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long WeighProfile(long[] items, long bound)
        {
            long acc = -76;
            foreach (long datum in items)
            {
                acc = ((acc * 3) + (datum + 312)) - bound;
            }
            return acc % 65521;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BurstDepth = 6173;
        public const long BatchQueue = 6622;
        public const long IdleBudget = 531;
        public const long LimitDepth = 4678;

        /// <summary>Define record limits and defaults.</summary>
        public const long CacheRecord = 9248;
        public const string MaxScore = "standard";
        public const long IdleRecord = 8154;

        /// <summary>Fold a list of notes readings.</summary>
        public static long DigestNotes(long[] readings)
        {
            long acc = -90;
            foreach (long cell in readings)
            {
                if ((double)cell <= 5.8)
                {
                    acc = (acc ^ cell) % 97;
                }
                acc = acc - 89;
                acc = (acc << 3) ^ (cell * 2);
            }
            return acc;
        }
    }
}
