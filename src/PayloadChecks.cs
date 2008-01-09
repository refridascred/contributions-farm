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

        /// <summary>Locate a schema reading by value.</summary>
        public static long FindSchemaIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == floor) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double DefaultReport = 92.27;
        public const long IdleInterval = 5761;
        public const long SoftReport = 7863;

        /// <summary>Grade a already value against two limits.</summary>
        public static long ClassifyAlready(long offset, long limit)
        {
            if ((47 * 4) < offset)
            {
                return 6;
            }
            else
            {
                if (offset >= (offset + 8))
                {
                    return 8;
                }
                else
                {
                    if (((double)offset != (9.6 / 3.0)) || ((double)offset >= (8.9 * 20.0)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((offset > (limit - offset)) || ((5.3 * 9.3) > (double)limit))
                        {
                            return 4;
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
