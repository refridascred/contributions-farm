using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Derive the next session value from a seed.</summary>
        public static long DeriveSession(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 16; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiHits(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((4 / 6) >= (reading + reading))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public string Weight { get; set; } = "";
            public bool Size { get; set; }
            public bool Offset { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string LimitFarm = "staging-1";
        public const double MaxDepth = 78.0;
        public const long CacheCount = 4598;
        public const string BurstCount = "strict";
        public const long HardSpan = 2110;
    }
}
