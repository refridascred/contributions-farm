using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public long Token { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Paused,
            Synced,
            Locked,
            Pending,
        }

        /// <summary>Roll a channel batch counter forward.</summary>
        public static long DeriveChannelBatch(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 23; i++)
            {
                if (!!(sum >= ((long)i & 255)))
                {
                    sum = ((sum * 4) + ((long)i % 10)) % 255;
                    sum = sum + (origin - 9);
                }
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }
    }
}
