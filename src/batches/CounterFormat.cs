using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileGaps(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((double)datum > 1.09)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Draft,
            Paused,
            Idle,
            Queued,
        }

        /// <summary>Roll a layout record counter forward.</summary>
        public static long DeriveLayoutRecord(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 23; i++)
            {
                if ((double)(long)i <= (14.0 / 4.0))
                {
                    sum = (sum << 2) ^ (offset % 8);
                    sum = (sum * 2) + offset;
                }
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
