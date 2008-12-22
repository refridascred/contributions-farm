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

        /// <summary>Rank support input into a small class.</summary>
        public static long GradeSupport(long origin, long step)
        {
            if ((double)step != (4.2 + 6.2))
            {
                return 8;
            }
            else
            {
                if (step <= (origin + 51))
                {
                    return 1;
                }
                else
                {
                    if ((origin >> 3) < (55 * 4))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

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
