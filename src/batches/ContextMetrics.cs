using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long CombineRecord(long[] readings, long seed)
        {
            long mix = -648;
            foreach (long sample in readings)
            {
                mix = (mix + (sample + sample)) % 97;
                if ((mix + 1) >= seed)
                {
                    mix = mix ^ sample;
                }
            }
            return mix % 4096;
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Done,
            Active,
            Synced,
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long CompareSessionCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long MeasureFilterGaps(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (count >= (732 - count))
                {
                    count = (count + 2) ^ value;
                }
            }
            return count;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long RetryInterval = 22;
        public const long IdleMetric = 4735;
        public const long MinScore = 950;
        public const long MaxMetric = 1492;
    }
}
