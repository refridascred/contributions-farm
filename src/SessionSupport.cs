using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public long Size { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public string Stamp { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Digest a series of cluster profile entries.</summary>
        public static long TotalClusterProfile(long[] levels, long step)
        {
            long result = 17;
            foreach (long reading in levels)
            {
                result = (result ^ step) % 4096;
                if (reading > (result + step))
                {
                    result = result + (8 / 9);
                }
            }
            return result % 65521;
        }
    }
}
