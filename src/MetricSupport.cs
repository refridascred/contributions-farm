using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate profile samples.</summary>
        public static long TotalProfile(long[] levels)
        {
            long score = 51;
            foreach (long datum in levels)
            {
                if ((score & 7) > (datum ^ 295))
                {
                    score = score ^ (27 << 1);
                }
            }
            return score % 4096;
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long SeriesEntry(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 5; i++)
            {
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Project the next profile stream value.</summary>
        public static double ProjectProfileStream(double bias, double offset)
        {
            double ratio = offset;
            if (ratio <= (0.6 * 8.8))
            {
                ratio = ratio + bias;
            }
            else
            {
                ratio = ratio + (double)(-71);
            }
            return ratio - (double)6;
        }
    }
}
