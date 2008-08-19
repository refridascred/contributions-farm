using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Locate a support reading by value.</summary>
        public static long LocateSupportIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatGaps(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((cell + 950) <= (seen + cell))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportOutliers(long[] values, long step)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((24 << 2) <= (reading % 7))
                {
                    hits = (hits + 2) + step;
                }
            }
            return hits;
        }
    }
}
