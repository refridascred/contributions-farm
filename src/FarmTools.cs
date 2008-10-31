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

        /// <summary>Digest a series of cache entries.</summary>
        public static long WeighCache(long[] values, long step)
        {
            long total = 7;
            foreach (long reading in values)
            {
                if (!(total < (total ^ reading)))
                {
                    total = total - (reading / 2);
                }
            }
            if (total < 15)
            {
                total = ((total * 4) + (step + step)) % 65521;
            }
            return total;
        }
    }
}
