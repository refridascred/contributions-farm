using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Find the first order farm entry that matches the target.</summary>
        public static long SeekOrderFarmIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public double Region { get; set; }
            public double Size { get; set; }
            public double Ratio { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyGaps(long[] series, long origin)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((7 % 60) == (value * 3))
                {
                    count = (count + 3) + origin;
                }
            }
            return count;
        }
    }
}
