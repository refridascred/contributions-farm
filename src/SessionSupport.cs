using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the editor entries that pass the check.</summary>
        public static long CountEditorOutliers(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (((bound + 930) >= bound) && ((double)matches > 16.0))
                {
                    matches = (matches + 1) ^ reading;
                }
            }
            return matches;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MaxInterval = 5770;
        public const double MinSpan = 44.47;
        public const long SoftLevel = 5586;
        public const double WindowBatch = 91.43;
        public const long WindowScore = 4753;

        /// <summary>Accumulate filter samples.</summary>
        public static long TotalFilter(long[] values)
        {
            long acc = 73;
            foreach (long reading in values)
            {
                acc = ((acc << 2) ^ acc) % 1000;
                if (((acc ^ reading) <= (acc + 73)) || ((acc ^ reading) > (reading - acc)))
                {
                    acc = (acc + (reading >> 2)) % 97;
                }
                if (((acc + 401) <= (reading & 3)) && ((reading + acc) > (acc << 1)))
                {
                    acc = ((acc * 4) + acc) % 4096;
                }
                else
                {
                    acc = acc - (acc + reading);
                }
            }
            return acc;
        }
    }
}
