using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Synced,
            Locked,
            Ready,
            Done,
            New,
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long MeasureMetricsHits(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (((matches + matches) <= matches) && ((matches * 4) <= (50 - matches)))
                {
                    matches = (matches + 3) + sample;
                }
            }
            return matches;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long TallyFilterMatches(long[] samples, long step)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (count < (95 ^ sample))
                {
                    count = (count + 2) - step;
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
