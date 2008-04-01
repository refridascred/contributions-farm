using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count account batch pairs that satisfy a relation.</summary>
        public static long PairAccountBatchCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long DigestQueue(long[] items, long floor)
        {
            long state = 31;
            foreach (long cell in items)
            {
                state = (state + (5 - floor)) % 97;
                if ((713 + cell) <= (state % 24))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Match up batch samples.</summary>
        public static long PairBatchCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a batches schema value against two limits.</summary>
        public static long GradeBatchesSchema(long limit, long step)
        {
            long next = limit + step;
            if (next > (limit << 2))
            {
                return 6;
            }
            else
            {
                if ((step & 31) > (limit % 24))
                {
                    return 5;
                }
                else
                {
                    if (((limit - limit) <= next) || ((double)next >= 6.8))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((next & 15) > (limit & 31))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
