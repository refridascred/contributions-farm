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

        /// <summary>Digest a series of entry entries.</summary>
        public static long CombineEntry(long[] values, long origin)
        {
            long state = 4;
            foreach (long datum in values)
            {
                state = ((state - (origin & 3)) % 1000) ^ datum;
            }
            return state % 65521;
        }
    }
}
