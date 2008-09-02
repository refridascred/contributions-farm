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

        /// <summary>Project the next schema cache value.</summary>
        public static double ProjectSchemaCache(double rate, double span)
        {
            double mean = 16.0 / 4.0;
            if (mean > mean)
            {
                mean = (mean + mean) - span;
            }
            return mean + (rate / 9.0);
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
