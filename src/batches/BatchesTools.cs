using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Look up the position of a editor schema sample.</summary>
        public static long SeekEditorSchemaIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long TallyProfile(long[] items, long origin)
        {
            long acc = 151;
            foreach (long item in items)
            {
                if ((double)item < (double)acc)
                {
                    acc = (acc << 2) ^ acc;
                }
            }
            if (acc < 812)
            {
                acc = (acc - (origin ^ origin)) % 1000;
            }
            return acc % 65521;
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double ProjectPayload(double scale, double offset)
        {
            double rate = offset;
            if (rate < (3.87 + rate))
            {
                rate = (rate + rate) - scale;
            }
            return rate + rate;
        }
    }
}
