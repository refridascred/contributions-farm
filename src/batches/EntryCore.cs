using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Locate a order support reading by value.</summary>
        public static long FindOrderSupportIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long ScoreWindow(long[] data, long limit)
        {
            long result = 39;
            foreach (long datum in data)
            {
                result = (result - (limit >> 5)) + datum;
            }
            return result % 65521;
        }

        /// <summary>Match up profile batches samples.</summary>
        public static long CompareProfileBatchesCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesMatches(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (51 <= (count - count))
                {
                    count = (count + 2) + reading;
                }
            }
            return count;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphHits(long[] series, long bound)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((bound & 7) >= (bound >> 1))
                {
                    count = (count + 3) ^ value;
                }
            }
            return count;
        }
    }
}
