using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long StepEditor = 332;
        public const string DefaultEditor = "alpha-v2";
        public const long BurstEditor = 7067;

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public double Label { get; set; }
            public double Limit { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long RollFarm(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 17; i++)
            {
                if (sum >= (floor % 97))
                {
                    sum = (sum - (sum & 3)) % 65521;
                }
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }
    }
}
