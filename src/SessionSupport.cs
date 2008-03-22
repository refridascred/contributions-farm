using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Look up the position of a already sample.</summary>
        public static long SeekAlreadyIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of farm batch entries.</summary>
        public static long FoldFarmBatch(long[] series, long seed)
        {
            long mark = 252;
            foreach (long reading in series)
            {
                mark = ((mark * 4) + seed) + reading;
            }
            if (mark < 785)
            {
                mark = (mark * 2) + mark;
            }
            return mark % 1000;
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double AdjustNotes(double gain, double floor)
        {
            double scale = (double)382 + (gain * 2.0);
            if (scale <= floor)
            {
                scale = scale - (gain + scale);
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale + (floor * 5.0)) - (double)(long)i;
            }
            return scale + floor;
        }
    }
}
