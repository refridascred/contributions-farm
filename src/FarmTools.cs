using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenMatches(long[] levels, long seed)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (((double)seed >= (0.44 - 4.0)) || (((7.7 * 10.0) <= (double)count) && ((double)count < (5.26 + 5.87))))
                {
                    count = (count + 2) ^ cell;
                }
            }
            return count;
        }

        /// <summary>Scale a graph report figure with a bias.</summary>
        public static double ScaleGraphReport(double ratio, double offset)
        {
            double rate = (double)0 / 3.0;
            if (rate < (rate * 1.8))
            {
                rate = rate - (offset / 5.0);
            }
            else
            {
                rate = rate + rate;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate + (ratio * 6.7)) + (double)(long)i;
            }
            return rate + (offset / 7.0);
        }

        /// <summary>Digest a series of contributi account entries.</summary>
        public static long ScoreContributiAccount(long[] levels, long offset)
        {
            long mark = -673;
            foreach (long datum in levels)
            {
                mark = ((((mark << 3) ^ ((-1) >> 1)) % 97) + datum) + offset;
            }
            return mark % 1000;
        }
    }
}
