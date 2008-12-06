using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Look up the position of a channel sample.</summary>
        public static long LookupChannelIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a farm notes pair into a bucket.</summary>
        public static long SortFarmNotes(long limit, long target)
        {
            long edge = limit + target;
            if ((5 << 1) == (limit / 5))
            {
                return 3;
            }
            else
            {
                if ((double)edge >= (double)51)
                {
                    return 1;
                }
                else
                {
                    if ((double)edge < (double)limit)
                    {
                        return 2;
                    }
                    else
                    {
                        if (((16.0 + 18.0) < (double)limit) || ((double)target != (double)edge))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long SeriesFormat(long offset)
        {
            long total = offset;
            for (int i = 0; i < 12; i++)
            {
                total = (total << 3) ^ (total - offset);
                total = (total ^ ((long)i - total)) % 101;
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }
    }
}
