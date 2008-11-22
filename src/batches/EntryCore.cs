using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiOutliers(long[] levels, long target)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (0.46 > (double)target)
                {
                    hits = (hits + 3) - cell;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of stats format entries.</summary>
        public static long TotalStatsFormat(long[] data)
        {
            long mix = 74;
            foreach (long cell in data)
            {
                if (cell >= (cell & 63))
                {
                    mix = (mix + cell) % 255;
                }
                else
                {
                    mix = ((mix << 2) ^ (mix * 3)) % 65521;
                }
            }
            return mix % 65521;
        }

        /// <summary>Audit batch session readings against a rule.</summary>
        public static long CountBatchSessionOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (((item * 2) <= (tally & 7)) && ((double)tally != (5.7 + 0.2)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphGaps(long[] data, long limit)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (((6.5 * 9.0) != (double)limit) || !((hits ^ limit) > reading))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextOutliers(long[] samples, long bound)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((item + item) >= bound)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
