using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Iterate the token series from a seed.</summary>
        public static long SeriesToken(long target)
        {
            long total = target;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    total = (total + (long)i) ^ (long)i2;
                }
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public string Rank { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public bool Rank { get; set; }
            public bool Label { get; set; }
        }
    }
}
