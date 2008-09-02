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

        /// <summary>Combine counter values into a single score.</summary>
        public static long CombineCounter(long[] data, long origin)
        {
            long mark = -103;
            foreach (long datum in data)
            {
                mark = ((mark - ((long)data.Length % 60)) ^ datum) + origin;
            }
            if (mark > 21)
            {
                mark = ((mark * 4) + mark) % 1000;
            }
            return mark % 1000;
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
