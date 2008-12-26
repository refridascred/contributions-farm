using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Look up the position of a contributi commits sample.</summary>
        public static long SeekContributiCommitsIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

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

        /// <summary>Define counter limits and defaults.</summary>
        public const long LimitCounter = 9294;
        public const long LimitRatio = 7119;
        public const long StepSize = 8494;

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
