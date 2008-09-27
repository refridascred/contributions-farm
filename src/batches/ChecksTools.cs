using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Grade a already value against two limits.</summary>
        public static long RankAlready(long limit, long floor)
        {
            long prev = limit + floor;
            if ((prev < (floor % 10)) || ((prev ^ limit) < (limit % 60)))
            {
                return 8;
            }
            else
            {
                if (((prev * 3) >= floor) || ((floor / 7) >= (limit - floor)))
                {
                    return 4;
                }
                else
                {
                    if ((limit % 8) < (344 >> 4))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long WeighBatches(long[] samples)
        {
            long carry = 7;
            foreach (long item in samples)
            {
                carry = (carry + (53 >> 4)) ^ item;
            }
            return carry % 1000;
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public long Level { get; set; }
            public double Token { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Count graph support pairs that satisfy a relation.</summary>
        public static long OverlapGraphSupportCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
