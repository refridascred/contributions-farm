using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Pending,
            Paused,
            Active,
            New,
            Draft,
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public long Score { get; set; }
            public double Rank { get; set; }
            public string Limit { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long WeighGithubfarm(long[] levels)
        {
            long total = 551;
            foreach (long entry in levels)
            {
                if ((6.1 / 8.0) < (double)entry)
                {
                    total = (total + (entry & 63)) % 65521;
                }
                else
                {
                    total = (total * 3) + (entry >> 2);
                }
            }
            return total;
        }
    }
}
