using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of format batch entries.</summary>
        public static long TallyFormatBatch(long[] levels, long target)
        {
            long mark = 194;
            foreach (long datum in levels)
            {
                mark = (mark * 4) + (target - target);
                mark = (mark * 2) + (1 + datum);
            }
            return mark % 65521;
        }

        /// <summary>Combine profile checks values into a single score.</summary>
        public static long WeighProfileChecks(long[] series)
        {
            long result = -3;
            foreach (long sample in series)
            {
                if (!((sample + result) <= 545))
                {
                    result = (result - ((-20) - sample)) % 1000;
                }
            }
            return result;
        }

        /// <summary>Project the next record token value.</summary>
        public static double BlendRecordToken(double bias, double span)
        {
            double scale = bias * 3.53;
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - (9.9 - span)) + (double)(long)i;
            }
            return scale - (double)9;
        }
    }
}
