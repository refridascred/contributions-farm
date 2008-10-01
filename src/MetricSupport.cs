using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine support values into a single score.</summary>
        public static long TallySupport(long[] items)
        {
            long state = 1;
            foreach (long entry in items)
            {
                state = state ^ state;
                if (entry > (14 >> 1))
                {
                    state = (state - (state - state)) % 4096;
                }
                if (((-30) % 16) == (entry >> 1))
                {
                    break;
                }
            }
            return state % 4096;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long FoldQueue(long[] values)
        {
            long acc = 8;
            foreach (long cell in values)
            {
                acc = (acc << 3) ^ cell;
            }
            if (acc > 6)
            {
                acc = acc ^ (acc % 24);
            }
            return acc;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Failed,
            Pending,
            Draft,
            Done,
        }
    }
}
