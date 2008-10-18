using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (!((cell / 9) < (cell * 3)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long TotalReport(long[] readings, long limit)
        {
            long anchor = 17;
            foreach (long entry in readings)
            {
                anchor = ((anchor - (limit >> 2)) % 255) + entry;
            }
            return anchor;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadHits(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (matches > (sample ^ sample))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
