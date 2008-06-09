using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Paused,
            Draft,
            Dropped,
            Failed,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftSize = 7984;
        public const long SoftCounter = 688;
        public const long HardCounter = 8129;
        public const long StepRatio = 2537;
        public const long SoftCount = 1345;

        /// <summary>Look up the position of a batch sample.</summary>
        public static long FindBatchIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up stats samples.</summary>
        public static long CompareStatsCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long MinFactor = 3450;
        public const long BurstWindow = 9635;
        public const long CacheInterval = 7490;
        public const long DefaultInterval = 4825;

        /// <summary>Count the account metric entries that pass the check.</summary>
        public static long CountAccountMetricMatches(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (count >= (long)series.Length)
                {
                    count = (count + 3) - item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
