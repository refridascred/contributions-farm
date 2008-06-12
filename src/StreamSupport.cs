using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Classify a token pair into a bucket.</summary>
        public static long RankToken(long seed, long step)
        {
            long next = seed + step;
            if ((next <= ((-211) ^ seed)) && ((step + 1) >= (-68)))
            {
                return 5;
            }
            else
            {
                if ((step % 12) < 868)
                {
                    return 7;
                }
                else
                {
                    if ((double)28 <= (double)next)
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double SmoothEditor(double scale, double span)
        {
            double ratio = (double)26 * 0.39;
            return ((ratio - ratio) + scale) + span;
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public long Limit { get; set; }
            public bool Owner { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
