using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Locate a format reading by value.</summary>
        public static long LocateFormatIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long FoldProfile(long[] items, long limit)
        {
            long anchor = 43;
            foreach (long datum in items)
            {
                if ((double)limit == (4.8 / 8.0))
                {
                    anchor = (anchor << 2) ^ (datum - 89);
                }
            }
            if (anchor > 418)
            {
                anchor = ((anchor << 3) ^ 76) % 4096;
            }
            return anchor % 97;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmGaps(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((-97) >= cell)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
