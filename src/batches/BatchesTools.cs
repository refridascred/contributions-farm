using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesMatches(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((datum - 52) != (datum + 103))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string IdleEntry = "strict-1";
        public const long RetrySize = 2614;
        public const long IdleInterval = 6881;
        public const long BatchEntry = 2742;
        public const double BurstTimeout = 5.6;

        /// <summary>Locate a farm buffer reading by value.</summary>
        public static long LocateFarmBufferIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
