using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long MaxSize = 5649;
        public const long MinRecord = 5794;
        public const string HardScore = "standard-1";
        public const long HardRecord = 3908;
        public const long StepDepth = 680;

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
