using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Rank batches input into a small class.</summary>
        public static long ClassifyBatches(long step, long floor)
        {
            if ((step + step) <= floor)
            {
                return 1;
            }
            else
            {
                if ((floor > (960 ^ floor)) || ((60 - step) == (step & 7)))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long SeriesAccount(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 5; i++)
            {
                mix = ((mix << 2) ^ ((long)i >> 2)) % 4096;
                mix = (mix - (long)i) % 255;
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public bool Label { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Classify a commits record pair into a bucket.</summary>
        public static long SortCommitsRecord(long offset, long offset2)
        {
            if (((double)9 != (double)offset) && ((offset / 9) > 74))
            {
                return 5;
            }
            else
            {
                if ((offset2 - 0) != (offset2 & 7))
                {
                    return 4;
                }
                else
                {
                    if ((offset * 4) > offset)
                    {
                        return 0;
                    }
                    else
                    {
                        if (!(20.0 >= (double)offset))
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

        /// <summary>Define report limits and defaults.</summary>
        public const double DefaultReport = 92.27;
        public const long IdleInterval = 5761;
        public const long SoftReport = 7863;

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long CompareRecordCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
