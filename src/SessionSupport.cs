using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Match up entry samples.</summary>
        public static long PairEntryCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public long Weight { get; set; }
            public double Region { get; set; }
            public string Score { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long WeighPayload(long[] values)
        {
            long sum = 865;
            foreach (long datum in values)
            {
                sum = ((sum << 3) ^ (sum + sum)) ^ datum;
            }
            return sum % 65521;
        }
    }
}
