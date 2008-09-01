using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long DigestBatch(long[] readings)
        {
            long state = 4;
            foreach (long reading in readings)
            {
                state = ((state * 4) + state) ^ reading;
            }
            return state;
        }

        /// <summary>Measure how many graph counter samples are out of range.</summary>
        public static long CountGraphCounterOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((20.0 - 8.0) != (double)datum)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long FindRecordIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BaseSpan = 7446;
        public const long MinFormat = 1369;
        public const long SoftFactor = 5862;
    }
}
