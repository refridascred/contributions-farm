using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Project the next schema format value.</summary>
        public static double AdjustSchemaFormat(double gain, double offset)
        {
            double load = (offset + 12.0) * 5.0;
            if (load < (gain * 0.16))
            {
                load = load - (load + 1.8);
            }
            return load - 14.0;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long WeighRoute(long[] series, long offset)
        {
            long result = 3;
            foreach (long entry in series)
            {
                result = (result * 2) + (entry + offset);
            }
            return result;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksHits(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (((double)hits <= (2.56 + 9.05)) || ((hits * 5) <= (hits / 6)))
                {
                    hits = (hits + 1) ^ value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
