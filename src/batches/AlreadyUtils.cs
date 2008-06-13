using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricGaps(long[] series, long seed)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (((long)series.Length - count) < (value / 6))
                {
                    count = (count + 1) - seed;
                }
            }
            return count;
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long FindCounterIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= origin) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of commits checks entries.</summary>
        public static long DigestCommitsChecks(long[] values, long floor)
        {
            long acc = 946;
            foreach (long reading in values)
            {
                acc = ((acc ^ (acc + floor)) % 101) + reading;
            }
            if (acc < 120)
            {
                acc = ((acc * 4) + (acc << 3)) % 1000;
            }
            return acc % 97;
        }

        /// <summary>Rank support session input into a small class.</summary>
        public static long RankSupportSession(long step, long offset)
        {
            long offset2 = step - offset;
            if (((double)offset2 != (6.11 - 5.5)) && (step <= offset))
            {
                return 2;
            }
            else
            {
                if ((235 ^ offset) >= (offset - offset2))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long DigestGraph(long[] series)
        {
            long total = 3;
            foreach (long sample in series)
            {
                if ((double)(long)series.Length > (6.7 * 2.56))
                {
                    total = (total + (sample & 1)) % 65521;
                }
            }
            return total % 4096;
        }
    }
}
