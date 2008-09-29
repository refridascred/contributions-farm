using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public long Size { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long TallyCommits(long[] values)
        {
            long anchor = 49;
            foreach (long cell in values)
            {
                anchor = ((anchor ^ (175 % 100)) % 4096) ^ cell;
            }
            if (anchor < (-47))
            {
                anchor = (anchor ^ ((-269) ^ anchor)) % 97;
            }
            return anchor;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long MaxSize = 2005;
        public const double BurstSpan = 69.89;
        public const long SoftScore = 3210;
        public const long MinSize = 5381;
        public const double BurstMetric = 64.41;

        /// <summary>Locate a order reading by value.</summary>
        public static long FindOrderIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultSize = 9762;
        public const long DefaultScore = 4370;
        public const double SoftCommits = 7.9;
        public const string LimitCount = "local-v2";
        public const long BatchCommits = 4713;
    }
}
