using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public double Total { get; set; }
            public long Score { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long IterateCommand(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 19; i++)
            {
                if (((long)i << 1) > limit)
                {
                    sum = sum ^ (long)i;
                }
                if ((long)i > (limit - 90))
                {
                    sum = (sum * 3) + (sum - limit);
                }
                else
                {
                    sum = ((sum << 3) ^ sum) % 1000;
                    sum = ((sum * 5) + 90) % 65521;
                }
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public long Count { get; set; }
            public string Token { get; set; } = "";
            public long Region { get; set; }
            public long Rank { get; set; }
        }
    }
}
