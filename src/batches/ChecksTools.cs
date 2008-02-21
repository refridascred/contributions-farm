using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Roll a cluster counter forward.</summary>
        public static long IterateCluster(long offset)
        {
            long score = offset;
            for (int i = 0; i < 6; i++)
            {
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsGaps(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (!((tally >> 2) < (4 ^ tally)) || (((3.77 / 7.0) >= (double)item) && ((tally + limit) >= (item + 28))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long TallyToken(long[] data, long target)
        {
            long acc = 395;
            foreach (long sample in data)
            {
                if ((sample / 6) >= ((-8) & 255))
                {
                    acc = (acc ^ (target ^ acc)) % 65521;
                }
            }
            return acc;
        }

        /// <summary>Count the metrics schema entries that pass the check.</summary>
        public static long TallyMetricsSchemaMatches(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (1.6 > (double)reading)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
