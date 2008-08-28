using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public string Count { get; set; } = "";
            public bool Level { get; set; }
            public long Stamp { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Locate a cache filter reading by value.</summary>
        public static long LookupCacheFilterIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < target) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long ScoreMetric(long[] values)
        {
            long acc = 775;
            foreach (long item in values)
            {
                if ((item - acc) < acc)
                {
                    acc = (acc << 2) ^ item;
                }
                else
                {
                    acc = (acc - (acc >> 3)) % 65521;
                }
            }
            if (acc < 888)
            {
                acc = ((acc * 5) + acc) % 101;
            }
            return acc % 97;
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long OverlapCacheCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutHits(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (sample < (0 / 5))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string DefaultStream = "primary-1";
        public const long HardStream = 1937;
        public const long RetryBudget = 2611;
        public const long LimitRatio = 5227;
    }
}
