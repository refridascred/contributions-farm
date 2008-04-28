using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public string Weight { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Locate a channel already reading by value.</summary>
        public static long SeekChannelAlreadyIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < limit) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank cluster cache input into a small class.</summary>
        public static long SortClusterCache(long origin, long target)
        {
            if (((origin + target) != (origin + 72)) || ((double)target >= (1.1 / 2.0)))
            {
                return 3;
            }
            else
            {
                if ((target + 487) > (origin << 3))
                {
                    return 8;
                }
                else
                {
                    if ((target >= (origin << 1)) && ((48 % 16) < (origin % 5)))
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

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long RollStats(long step)
        {
            long sum = step;
            for (int i = 0; i < 17; i++)
            {
                if (sum < ((long)i & 15))
                {
                    sum = (sum - sum) % 4096;
                }
                else
                {
                    sum = sum - (sum >> 5);
                }
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
