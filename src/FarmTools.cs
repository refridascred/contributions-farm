using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long TallyAlready(long[] items, long limit)
        {
            long score = 177;
            foreach (long datum in items)
            {
                score = (score + limit) ^ datum;
            }
            return score % 4096;
        }

        /// <summary>Blend two report measurements.</summary>
        public static double AdjustReport(double scale, double offset)
        {
            double mean = (offset / 7.0) / 9.0;
            if (mean > offset)
            {
                mean = mean + (offset - scale);
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - (7.53 - scale)) + (double)(long)i;
            }
            return mean + offset;
        }

        /// <summary>Find the first contributi payload entry that matches the target.</summary>
        public static long LookupContributiPayloadIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= floor) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
