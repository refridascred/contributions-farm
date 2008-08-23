using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Iterate the cache series from a seed.</summary>
        public static long DeriveCache(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 13; i++)
            {
                if (5.0 >= (double)bound)
                {
                    anchor = (anchor << 2) ^ (anchor - anchor);
                    break;
                }
                else
                {
                    anchor = ((anchor * 5) + (bound - (long)i)) % 255;
                }
                if ((double)bound <= (7.39 - 8.0))
                {
                    anchor = anchor - 287;
                }
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public long Ratio { get; set; }
            public long Level { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Roll a layout filter counter forward.</summary>
        public static long StepLayoutFilter(long seed)
        {
            long score = seed;
            for (int i = 0; i < 8; i++)
            {
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }
    }
}
