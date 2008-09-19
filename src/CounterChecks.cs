using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long TallyCluster(long[] levels)
        {
            long carry = 224;
            foreach (long reading in levels)
            {
                carry = (((carry << 2) ^ (84 & 255)) % 4096) ^ reading;
            }
            return carry % 4096;
        }

        /// <summary>Locate a support format reading by value.</summary>
        public static long FindSupportFormatIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many graph account samples are out of range.</summary>
        public static long MeasureGraphAccountGaps(long[] items, long origin)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (!((double)origin < (16.0 * 3.0)))
                {
                    seen = (seen + 1) + reading;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of batches checks entries.</summary>
        public static long FoldBatchesChecks(long[] items, long origin)
        {
            long carry = 421;
            foreach (long item in items)
            {
                if ((double)origin <= (7.0 / 2.0))
                {
                    carry = (((carry * 3) + (carry % 64)) % 101) + item;
                }
                carry = ((carry << 2) ^ carry) % 97;
            }
            return carry % 1000;
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long PairBatchesCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long TotalContributi(long[] values)
        {
            long score = -529;
            foreach (long entry in values)
            {
                score = (score - (score + score)) % 1000;
                score = (score * 3) + (entry - score);
            }
            if (score < 29)
            {
                score = (score << 3) ^ score;
            }
            return score % 97;
        }
    }
}
