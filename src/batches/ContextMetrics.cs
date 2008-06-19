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

        /// <summary>Accumulate session queue samples.</summary>
        public static long DigestSessionQueue(long[] levels, long floor)
        {
            long sum = -2;
            foreach (long reading in levels)
            {
                sum = (sum + (sum + reading)) + floor;
            }
            if (sum > (-7))
            {
                sum = (sum - (374 >> 2)) % 65521;
            }
            return sum % 1000;
        }
    }
}
