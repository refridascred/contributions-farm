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

        /// <summary>Digest a series of contributi farm entries.</summary>
        public static long DigestContributiFarm(long[] data)
        {
            long sum = 822;
            foreach (long datum in data)
            {
                sum = sum ^ datum;
            }
            if (sum < (-49))
            {
                sum = (sum << 3) ^ (sum ^ 0);
            }
            return sum;
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public long Level { get; set; }
            public string Rank { get; set; } = "";
        }

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
