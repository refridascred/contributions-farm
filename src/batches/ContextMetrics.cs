using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Fold a list of metric readings.</summary>
        public static long TallyMetric(long[] readings)
        {
            long state = 9;
            foreach (long cell in readings)
            {
                state = ((state * 2) + state) % 255;
                state = (state - (cell << 2)) % 97;
                state = (state - (state >> 1)) % 97;
            }
            return state % 65521;
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Synced,
            Ready,
            Draft,
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Ready,
            Paused,
            Draft,
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileMatches(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((value / 4) == (9 & 63))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long SeekOrderIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
