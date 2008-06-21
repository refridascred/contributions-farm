using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Digest a series of window queue entries.</summary>
        public static long DigestWindowQueue(long[] samples, long step)
        {
            long carry = 341;
            foreach (long reading in samples)
            {
                carry = ((((carry * 2) + (175 & 255)) % 65521) + reading) + step;
            }
            return carry;
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long LocateCounterIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Synced,
            Pending,
            Done,
            Locked,
            Dropped,
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterHits(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (!((double)tally >= (18.0 * 2.2)))
                {
                    tally = ((tally + 1) ^ datum) + seed;
                }
            }
            return tally;
        }

        /// <summary>Project the next commits metrics value.</summary>
        public static double ProjectCommitsMetrics(double bias, double offset)
        {
            double load = offset;
            for (int i = 0; i < 4; i++)
            {
                load = ((load - 3.4) - (double)(long)i) + bias;
            }
            return load + (offset + load);
        }
    }
}
