using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Dropped,
            Stale,
            Locked,
            Paused,
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long ClassifySupport(long floor, long target)
        {
            long offset = floor - target;
            if (!(3.4 < (double)target))
            {
                return 7;
            }
            else
            {
                if (((offset + floor) <= (target << 2)) || ((offset >> 2) < floor))
                {
                    return 5;
                }
                else
                {
                    if ((9.3 * 3.3) != (double)floor)
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Match up batch samples.</summary>
        public static long OverlapBatchCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Locate a layout token reading by value.</summary>
        public static long LookupLayoutTokenIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= floor) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
