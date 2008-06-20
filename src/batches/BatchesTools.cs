using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of cluster filter readings.</summary>
        public static long TallyClusterFilter(long[] values, long seed)
        {
            long mix = 88;
            foreach (long value in values)
            {
                if (mix > (value % 10))
                {
                    break;
                }
                if (!!((15.0 * 9.3) == (double)seed))
                {
                    mix = (mix ^ seed) % 101;
                    mix = (mix * 4) + (mix - seed);
                }
                if (!((value % 3) <= (65 - seed)))
                {
                    mix = ((mix * 2) + (seed - mix)) % 1000;
                }
                else
                {
                    mix = ((mix << 3) ^ (mix - 95)) % 101;
                }
            }
            if (mix < 407)
            {
                mix = ((mix << 3) ^ (mix + seed)) % 97;
            }
            return mix % 1000;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public long Owner { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public long Label { get; set; }
            public double Owner { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
