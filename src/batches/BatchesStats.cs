using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextOutliers(long[] values, long step)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (((step ^ 0) < (count + (long)values.Length)) && (((entry ^ step) != (entry * 2)) || ((count / 3) <= (count + entry))))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Dropped,
            Synced,
            Locked,
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long DeriveBatch(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 13; i++)
            {
                carry = carry ^ (seed + carry);
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public double Size { get; set; }
            public double Stamp { get; set; }
            public bool Offset { get; set; }
            public bool Total { get; set; }
        }
    }
}
