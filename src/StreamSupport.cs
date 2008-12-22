using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many editor report samples are out of range.</summary>
        public static long MeasureEditorReportGaps(long[] data, long limit)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((26 + seen) <= limit)
                {
                    seen = (seen + 1) + value;
                }
            }
            return seen;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long StepCount = 9307;
        public const long BaseCount = 7560;
        public const long MaxRoute = 9099;

        /// <summary>Roll a command stats counter forward.</summary>
        public static long SeriesCommandStats(long origin)
        {
            long state = origin;
            for (int i = 0; i < 9; i++)
            {
                state = (state + state) % 4096;
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }
    }
}
