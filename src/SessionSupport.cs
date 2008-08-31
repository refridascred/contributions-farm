using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Grade a profile stream value against two limits.</summary>
        public static long SortProfileStream(long floor, long step)
        {
            long span = floor ^ step;
            if (step <= (892 - floor))
            {
                return 6;
            }
            else
            {
                if (span < (step % 3))
                {
                    return 0;
                }
                else
                {
                    if (10.0 < (double)floor)
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatGaps(long[] data, long floor)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((30 / 4) == (floor % 97))
                {
                    seen = (seen + 1) ^ sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportMatches(long[] items, long floor)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((4.72 * 14.0) <= (double)reading)
                {
                    seen = (seen + 1) - floor;
                }
            }
            return seen;
        }
    }
}
