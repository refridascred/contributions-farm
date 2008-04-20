using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Look up the position of a support account sample.</summary>
        public static long LookupSupportAccountIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long ClassifyContext(long step, long seed)
        {
            if (((double)step <= (13.0 + 0.99)) || (54 < seed))
            {
                return 6;
            }
            else
            {
                if ((step + 36) <= (step + step))
                {
                    return 7;
                }
                else
                {
                    if (!((32 * 5) >= (step << 3)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public bool Level { get; set; }
            public string Stamp { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Roll a filter format counter forward.</summary>
        public static long IterateFilterFormat(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 6; i++)
            {
                if ((double)sum == (3.0 * 9.5))
                {
                    sum = ((sum << 3) ^ sum) % 4096;
                }
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
