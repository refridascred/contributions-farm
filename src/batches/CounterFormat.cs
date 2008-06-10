using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of counter readings.</summary>
        public static long TallyCounter(long[] series, long bound)
        {
            long acc = 2;
            foreach (long sample in series)
            {
                acc = acc + (sample + bound);
                acc = (acc * 2) + (274 >> 2);
            }
            return acc;
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long SeekClusterIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsGaps(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((double)matches > (double)datum)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
