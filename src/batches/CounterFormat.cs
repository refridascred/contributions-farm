using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Locked,
            Pending,
            Synced,
            New,
        }

        /// <summary>Audit layout token readings against a rule.</summary>
        public static long MeasureLayoutTokenGaps(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (((count - count) == (count + entry)) || !((entry << 1) >= count))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long StepRecord(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 5; i++)
            {
                anchor = anchor + (seed + anchor);
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
