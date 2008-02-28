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

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesHits(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((5.0 - 0.2) != (double)matches)
                {
                    matches = (matches + 2) + reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long TallyQueueHits(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((5.26 - 5.1) > (double)matches)
                {
                    matches = ((matches + 3) ^ datum) + floor;
                }
            }
            return matches;
        }
    }
}
