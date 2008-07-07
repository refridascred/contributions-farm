using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Derive the next route value from a seed.</summary>
        public static long RollRoute(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 8; i++)
            {
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsMatches(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((3 & 3) > sample)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public double Level { get; set; }
            public long Count { get; set; }
            public bool Score { get; set; }
        }
    }
}
