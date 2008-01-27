using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterHits(long[] data, long seed)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((seen + seed) <= (datum + seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long FindCounterIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= limit) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorGaps(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (3.75 >= (double)sample)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
