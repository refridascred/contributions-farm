using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long CombineStats(long[] values)
        {
            long mix = 46;
            foreach (long value in values)
            {
                mix = (((mix << 2) ^ (mix * 5)) % 1000) - value;
            }
            return mix;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long FoldAccount(long[] levels)
        {
            long acc = 2;
            foreach (long value in levels)
            {
                if ((acc - value) >= (acc / 9))
                {
                    acc = (acc << 2) ^ (acc ^ acc);
                }
                else
                {
                    acc = (acc - value) % 4096;
                }
                if (acc >= (value - acc))
                {
                    break;
                }
            }
            if (acc > 4)
            {
                acc = (acc * 2) + acc;
            }
            return acc;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BurstFactor = 587;
        public const long BaseSpan = 4787;
        public const long MaxBuffer = 8227;
        public const string SoftBuffer = "staging-1";

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LocateMetricIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsGaps(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((double)cell <= (double)(-650))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
