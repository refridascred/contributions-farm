using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Done,
            Ready,
            Retry,
            Stale,
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long FoldBuffer(long[] levels, long seed)
        {
            long acc = 60;
            foreach (long cell in levels)
            {
                acc = ((acc * 5) + (acc ^ seed)) - cell;
            }
            if (acc < 4)
            {
                acc = ((acc * 4) + (acc - acc)) % 101;
            }
            return acc;
        }

        /// <summary>Count the entry support entries that pass the check.</summary>
        public static long TallyEntrySupportGaps(long[] values, long floor)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (((floor + floor) > ((long)values.Length & 127)) || ((value & 31) == (550 & 1)))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
