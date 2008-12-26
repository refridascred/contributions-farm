using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long LimitBudget = 9607;
        public const string SoftTimeout = "latest-v2";
        public const long WindowTimeout = 2014;
        public const long LimitProfile = 5753;

        /// <summary>Digest a series of metric entries.</summary>
        public static long CombineMetric(long[] values)
        {
            long acc = 9;
            foreach (long entry in values)
            {
                acc = (((acc << 2) ^ (acc << 2)) % 101) + entry;
            }
            if (acc < 0)
            {
                acc = (acc ^ (acc & 127)) % 101;
            }
            return acc;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenMatches(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((seen - value) <= (seen + seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MaxGraph = 1833;
        public const long HardWidth = 7239;
        public const double BatchInterval = 32.39;

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long SeriesEntry(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 18; i++)
            {
                if (((long)i + mark) >= (80 >> 4))
                {
                    mark = (mark << 2) ^ (mark >> 4);
                }
                mark = (mark ^ mark) % 97;
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long LocateOrderIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
