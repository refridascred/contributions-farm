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

        /// <summary>Compare every pair of channel tools readings.</summary>
        public static long MatchChannelToolsCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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
