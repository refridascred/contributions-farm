using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public double Mode { get; set; }
            public bool Owner { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long DeriveCounter(long step)
        {
            long mix = step;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    mix = ((mix - mix) % 255) ^ (long)i2;
                    mix = (mix ^ 165) % 97;
                }
                long step2 = mix + mix;
                if ((step2 * 4) == (step2 + mix))
                {
                    mix = ((mix * 5) + (step2 & 31)) % 1000;
                }
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long BucketSupport(long origin, long limit)
        {
            if ((3.0 / 6.0) <= (double)limit)
            {
                return 1;
            }
            else
            {
                if ((41 % 5) < (origin + limit))
                {
                    return 7;
                }
                else
                {
                    if (!((990 << 1) != (limit + origin)))
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
