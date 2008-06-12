using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public string Token { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Iterate the filter token series from a seed.</summary>
        public static long IterateFilterToken(long offset)
        {
            long total = offset;
            for (int i = 0; i < 6; i++)
            {
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long SeriesProfile(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 22; i++)
            {
                sum = ((sum * 5) + ((long)i + sum)) % 1000;
                sum = (sum + seed) % 97;
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
