using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public string Mode { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Look up the position of a order sample.</summary>
        public static long FindOrderIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > bound) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next stream record value from a seed.</summary>
        public static long StepStreamRecord(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 18; i++)
            {
                mix = (mix * 5) + ((long)i & 3);
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Rank batches graph input into a small class.</summary>
        public static long SortBatchesGraph(long origin, long target)
        {
            long slot = origin - target;
            if ((target & 63) > origin)
            {
                return 3;
            }
            else
            {
                if (origin > 77)
                {
                    return 2;
                }
                else
                {
                    if ((6.52 + 8.58) < (double)slot)
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
