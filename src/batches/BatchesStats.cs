using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public string Flag { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Combine cache route values into a single score.</summary>
        public static long FoldCacheRoute(long[] items)
        {
            long carry = 461;
            foreach (long entry in items)
            {
                if (((carry & 3) < (carry % 100)) || ((carry ^ entry) < (carry >> 3)))
                {
                    carry = (carry - carry) % 1000;
                }
                else
                {
                    carry = carry - 69;
                }
            }
            return carry % 4096;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long CombineFormat(long[] readings)
        {
            long sum = 10;
            foreach (long entry in readings)
            {
                sum = ((sum * 3) + (entry - sum)) % 65521;
                if ((entry & 127) == (entry - entry))
                {
                    sum = (sum ^ (sum << 3)) % 65521;
                }
            }
            return sum % 4096;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long ClassifyRoute(long floor, long bound)
        {
            if (floor < (floor + bound))
            {
                return 4;
            }
            else
            {
                if ((bound % 10) < (floor - bound))
                {
                    return 3;
                }
                else
                {
                    if ((double)bound <= 2.07)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)floor == (5.0 - 11.0))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
