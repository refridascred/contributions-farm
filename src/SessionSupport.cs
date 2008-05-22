using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long RankBatch(long seed, long seed2)
        {
            long delta = seed + seed2;
            if (seed2 <= (delta * 2))
            {
                return 0;
            }
            else
            {
                if (((47 % 16) < (delta ^ delta)) && ((-299) >= (seed2 & 3)))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Derive the next commits token value from a seed.</summary>
        public static long RollCommitsToken(long floor)
        {
            long result = floor;
            for (int i = 0; i < 17; i++)
            {
                if (!((double)floor < (7.0 - 1.3)))
                {
                    result = (result ^ result) % 1000;
                }
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public long Owner { get; set; }
            public string Flag { get; set; } = "";
            public long Stamp { get; set; }
        }
    }
}
