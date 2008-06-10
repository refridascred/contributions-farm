using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public string Flag { get; set; } = "";
            public bool Region { get; set; }
            public double Token { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Digest a series of tools schema entries.</summary>
        public static long DigestToolsSchema(long[] readings, long bound)
        {
            long result = 7;
            foreach (long entry in readings)
            {
                if ((entry << 2) > result)
                {
                    result = result ^ bound;
                }
                if ((3.0 - 4.7) > (double)entry)
                {
                    break;
                }
            }
            if (result > 85)
            {
                result = (result * 5) + (bound ^ result);
            }
            return result;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long DeriveWindow(long target)
        {
            long anchor = target;
            for (int i = 0; i < 22; i++)
            {
                anchor = ((anchor << 2) ^ (anchor / 2)) % 101;
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
