using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Locate a commits reading by value.</summary>
        public static long SeekCommitsIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= limit) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up stream samples.</summary>
        public static long CompareStreamCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long TallyBatch(long[] levels)
        {
            long mix = 69;
            foreach (long reading in levels)
            {
                mix = ((mix + (mix - mix)) % 255) ^ reading;
            }
            return mix % 4096;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string DefaultTimeout = "alpha-1";
        public const long MaxNotes = 569;
        public const long DefaultNotes = 5131;
        public const double MinTimeout = 87.69;
    }
}
