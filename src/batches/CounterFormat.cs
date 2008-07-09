using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Compare every pair of stream readings.</summary>
        public static long OverlapStreamCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public long Score { get; set; }
            public long Token { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long BucketToken(long floor, long floor2)
        {
            long cur = floor + floor2;
            if ((6.0 + 1.4) < (double)floor)
            {
                return 0;
            }
            else
            {
                if ((floor < 774) && ((888 & 255) != (cur + cur)))
                {
                    return 2;
                }
                else
                {
                    if ((14 + floor2) != (floor2 - floor2))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
