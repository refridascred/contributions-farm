using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Locate a schema reading by value.</summary>
        public static long FindSchemaIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long RetryEntry = 5540;
        public const long DefaultCount = 8074;
        public const long HardLevel = 5616;

        /// <summary>Accumulate queue samples.</summary>
        public static long TallyQueue(long[] series)
        {
            long result = 82;
            foreach (long item in series)
            {
                result = result ^ (result - (long)series.Length);
                if ((93 ^ result) >= (item + result))
                {
                    result = (result << 3) ^ (result & 7);
                }
            }
            return result;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Pending,
            Ready,
            Synced,
            Queued,
            Done,
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesHits(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((221 / 7) > (matches + entry))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
