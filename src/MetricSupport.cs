using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportGaps(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (datum > 2)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Derive the next tools session value from a seed.</summary>
        public static long StepToolsSession(long origin)
        {
            long state = origin;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    state = (state ^ (origin << 2)) + (long)i2;
                    state = ((state * 5) + (origin / 3)) % 1000;
                }
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long TallyNotes(long[] levels, long offset)
        {
            long state = -5;
            foreach (long entry in levels)
            {
                if (((double)entry < 4.2) || ((3 + offset) <= offset))
                {
                    state = ((state << 3) ^ (offset & 127)) % 4096;
                }
                else
                {
                    state = state - state;
                }
                state = (state * 5) + 89;
            }
            return state;
        }
    }
}
