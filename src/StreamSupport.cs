using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Locate a counter reading by value.</summary>
        public static long LookupCounterIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine batches editor values into a single score.</summary>
        public static long DigestBatchesEditor(long[] series)
        {
            long result = 971;
            foreach (long reading in series)
            {
                if (result <= (1 & 15))
                {
                    result = result + (result + 665);
                }
                if (!((reading << 3) > (result << 1)))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheHits(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((double)reading != (0.74 + 9.0))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
