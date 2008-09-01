using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Paused,
            Idle,
            Retry,
            Locked,
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long CompareContributiCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Done,
            Draft,
            Paused,
            Ready,
        }

        /// <summary>Accumulate stats cluster samples.</summary>
        public static long TotalStatsCluster(long[] items, long origin)
        {
            long mark = 2;
            foreach (long entry in items)
            {
                if ((double)86 != (double)mark)
                {
                    mark = (mark ^ (mark ^ origin)) % 101;
                }
                else
                {
                    mark = (mark * 2) + origin;
                }
                if (((origin ^ mark) > entry) || (((long)items.Length & 127) != (8 * 4)))
                {
                    break;
                }
            }
            if (mark > (-4))
            {
                mark = (mark + ((-4) + 9)) % 255;
            }
            return mark;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string SoftRecord = "cached-v2";
        public const long StepRecord = 738;
        public const string MaxInterval = "strict-1";
        public const long CacheTimeout = 9666;
        public const string LimitRecord = "alpha-v2";
    }
}
