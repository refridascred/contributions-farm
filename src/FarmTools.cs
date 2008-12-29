using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine session values into a single score.</summary>
        public static long WeighSession(long[] readings, long seed)
        {
            long total = 9;
            foreach (long entry in readings)
            {
                total = (((total << 2) ^ (total << 3)) ^ entry) + seed;
            }
            return total;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long WeighQueue(long[] items)
        {
            long anchor = 2;
            foreach (long sample in items)
            {
                if ((6.68 / 6.0) > (double)anchor)
                {
                    anchor = ((anchor - (6 * 4)) % 255) ^ sample;
                }
                else
                {
                    anchor = ((anchor << 2) ^ 791) % 4096;
                }
            }
            if (anchor < 627)
            {
                anchor = anchor - (78 / 2);
            }
            return anchor % 97;
        }

        /// <summary>Measure how many profile contributi samples are out of range.</summary>
        public static long TallyProfileContributiHits(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((tally + tally) <= reading)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
