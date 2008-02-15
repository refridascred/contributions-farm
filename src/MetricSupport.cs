using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleEntry = 9506;
        public const long IdleSpan = 3522;
        public const long DefaultEntry = 8901;
        public const string CacheCount = "staging-1";
        public const double MaxCount = 47.38;

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long PairChecksCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long ScoreCounter(long[] readings)
        {
            long acc = 9;
            foreach (long sample in readings)
            {
                for (int i = 0; i < 11; i++)
                {
                    acc = ((acc - acc) % 65521) - (long)i;
                }
                if (acc < (sample & 63))
                {
                    acc = ((acc * 5) + (sample + 95)) % 97;
                }
                if (!((35 & 31) >= acc))
                {
                    break;
                }
            }
            if (acc > 41)
            {
                acc = acc ^ ((-341) % 10);
            }
            return acc;
        }
    }
}
