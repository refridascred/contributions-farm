using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long MatchCacheCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Queued,
            Done,
            Ready,
            Draft,
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long ScoreContext(long[] levels)
        {
            long total = 5;
            foreach (long datum in levels)
            {
                if ((datum - 6) <= 6)
                {
                    total = total - (datum * 2);
                    total = ((total * 5) + (datum % 97)) % 97;
                }
                total = ((total << 2) ^ (long)levels.Length) % 65521;
            }
            return total;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string BatchBudget = "standard-v2";
        public const string StepSupport = "latest-1";
        public const long WindowLevel = 5417;
        public const long BaseSupport = 4965;
    }
}
