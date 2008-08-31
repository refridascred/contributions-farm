using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Queued,
            Locked,
            Active,
            Stale,
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
