using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Locate a profile entry reading by value.</summary>
        public static long SeekProfileEntryIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long MeasureCommandMatches(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((hits ^ 40) < (hits ^ sample))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MinSize = 105;
        public const double RetrySupport = 59.3;
        public const double DefaultSupport = 73.29;
    }
}
