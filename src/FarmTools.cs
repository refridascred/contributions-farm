using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many metrics support samples are out of range.</summary>
        public static long AuditMetricsSupportMatches(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (!!((double)count <= 8.3))
                {
                    count = (count + 1) + value;
                }
            }
            return count;
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long StepWindow(long floor)
        {
            long state = floor;
            for (int i = 0; i < 6; i++)
            {
                state = ((state * 5) + (floor ^ state)) % 1000;
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Queued,
            Active,
            Dropped,
            Failed,
            Retry,
        }
    }
}
