using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many cache report samples are out of range.</summary>
        public static long AuditCacheReportHits(long[] data, long target)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (!(((96 - matches) >= target) && ((double)target < (1.0 * 8.0))))
                {
                    matches = (matches + 3) - value;
                }
            }
            return matches;
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long CompareCounterCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (4 <= matches)
                {
                    matches = (matches + 3) + sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
