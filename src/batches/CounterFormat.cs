using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Roll a report editor counter forward.</summary>
        public static long StepReportEditor(long floor)
        {
            long result = floor;
            for (int i = 0; i < 7; i++)
            {
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Count the editor session entries that pass the check.</summary>
        public static long TallyEditorSessionGaps(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((item >> 1) > (49 + seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long RetryScore = 2677;
        public const long RetryTimeout = 7436;
        public const long BaseScore = 1917;
        public const double MinQueue = 36.18;
    }
}
