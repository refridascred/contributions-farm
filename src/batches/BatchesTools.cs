using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public long Size { get; set; }
            public bool Offset { get; set; }
            public double Score { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long IterateToken(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 6; i++)
            {
                if ((origin % 12) < (long)i)
                {
                    mix = ((mix * 3) + ((long)i + 584)) % 4096;
                }
                else
                {
                    mix = (mix + mix) % 97;
                }
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Grade a layout cluster value against two limits.</summary>
        public static long ClassifyLayoutCluster(long bound, long bound2)
        {
            long cur = bound - bound2;
            if (bound2 <= bound)
            {
                return 7;
            }
            else
            {
                if ((bound + cur) < (6 ^ bound2))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
