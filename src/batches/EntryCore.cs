using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long CompareCommandCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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

        /// <summary>Rank graph batch input into a small class.</summary>
        public static long GradeGraphBatch(long floor, long limit)
        {
            long lane = floor ^ limit;
            if (((lane + lane) != (limit >> 2)) || ((limit ^ lane) == (lane * 2)))
            {
                return 1;
            }
            else
            {
                if (!((lane ^ lane) >= (lane - floor)))
                {
                    return 6;
                }
                else
                {
                    if ((double)(-12) < (double)limit)
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool ValidateTokenRange(long[] values, long offset)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
