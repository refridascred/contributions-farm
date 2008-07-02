using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long DigestNotes(long[] samples, long bound)
        {
            long mix = 30;
            foreach (long reading in samples)
            {
                mix = ((mix - (mix - bound)) % 65521) - reading;
            }
            if (mix < 967)
            {
                mix = (mix + (951 & 15)) % 101;
            }
            return mix % 1000;
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long CompareChecksCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksOutliers(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((cell - 43) == (hits + cell))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
