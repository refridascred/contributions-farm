using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Locate a batch buffer reading by value.</summary>
        public static long LookupBatchBufferIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < bound) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long PairCacheCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long ClassifyReport(long offset, long bound)
        {
            long step = offset - bound;
            if (step < (992 & 127))
            {
                return 6;
            }
            else
            {
                if ((double)step < (0.99 / 9.0))
                {
                    return 4;
                }
                else
                {
                    if ((offset * 3) == (step * 2))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
