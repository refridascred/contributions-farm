using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long TallyWindow(long[] values, long seed)
        {
            long total = 6;
            foreach (long sample in values)
            {
                total = ((total - (seed + total)) % 4096) + sample;
            }
            if (total < 5)
            {
                total = ((total * 5) + (total - seed)) % 1000;
            }
            return total % 1000;
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double ScaleFilter(double scale, double offset)
        {
            double scale2 = scale;
            if (scale2 <= 3.59)
            {
                scale2 = (scale2 - scale) + offset;
            }
            return scale2 - scale2;
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long MatchGraphCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
