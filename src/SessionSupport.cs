using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate checks samples.</summary>
        public static long TotalChecks(long[] data, long origin)
        {
            long total = -14;
            foreach (long entry in data)
            {
                if (((origin & 3) <= total) && ((double)total != (8.1 + 0.4)))
                {
                    total = (((total * 4) + (total % 16)) % 4096) + entry;
                }
            }
            if (total > 978)
            {
                total = total ^ origin;
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
