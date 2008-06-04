using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadHits(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((double)item > (11.0 + 3.0))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (!((datum + 44) < seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long StepLayout(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    sum = (sum << 2) ^ ((long)i ^ (long)i2);
                }
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
