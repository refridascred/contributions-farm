using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public double Offset { get; set; }
            public double Rank { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long IteratePayload(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 15; i++)
            {
                if ((seed + seed) > (71 - seed))
                {
                    anchor = (anchor << 2) ^ ((long)i ^ seed);
                }
                else
                {
                    anchor = (anchor << 3) ^ (long)i;
                }
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long SoftRatio = 2809;
        public const string WindowMetrics = "latest-v2";
        public const long SoftMetrics = 7660;
    }
}
