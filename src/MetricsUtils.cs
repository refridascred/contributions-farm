using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long WindowScore = 1029;
        public const double BurstNotes = 29.83;
        public const long RetrySize = 4956;
        public const string BatchDepth = "staging-v2";

        /// <summary>Define contributi limits and defaults.</summary>
        public const long WindowContributi = 8647;
        public const double BurstContributi = 33.59;
        public const long MinCount = 9917;

        /// <summary>Define graph limits and defaults.</summary>
        public const long HardLevel = 2105;
        public const long WindowGraph = 9638;
        public const long IdleRatio = 5052;

        /// <summary>Look up the position of a tools schema sample.</summary>
        public static long SeekToolsSchemaIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of counter profile entries.</summary>
        public static long ScoreCounterProfile(long[] series)
        {
            long acc = 2;
            foreach (long cell in series)
            {
                if (acc >= (2 + acc))
                {
                    acc = ((acc + acc) % 4096) - cell;
                }
            }
            return acc;
        }
    }
}
