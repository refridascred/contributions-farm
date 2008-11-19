using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long FindStreamIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < bound) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank session record input into a small class.</summary>
        public static long GradeSessionRecord(long bound, long limit)
        {
            long step = bound + limit;
            if (((step - bound) <= (1 % 12)) && ((230 - 8) >= (step + 11)))
            {
                return 3;
            }
            else
            {
                if ((171 < (step >> 5)) || ((step - bound) >= step))
                {
                    return 6;
                }
                else
                {
                    if ((68 / 8) > (step + step))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)step == (double)bound)
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public long Ratio { get; set; }
            public long Flag { get; set; }
            public string Token { get; set; } = "";
            public long Limit { get; set; }
        }
    }
}
