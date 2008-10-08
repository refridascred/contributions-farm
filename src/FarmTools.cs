using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public double Label { get; set; }
            public long Size { get; set; }
            public string Region { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Active,
            Paused,
            Failed,
            Stale,
            Done,
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long DeriveOrder(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 16; i++)
            {
                if ((acc + (long)i) >= floor)
                {
                    acc = (acc << 2) ^ (acc + acc);
                }
                if ((((long)i + 48) <= (acc / 9)) || ((acc + acc) >= floor))
                {
                    acc = acc ^ acc;
                    acc = ((acc * 4) + ((long)i & 15)) % 97;
                }
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
