using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long FoldQueue(long[] levels, long target)
        {
            long mix = 62;
            foreach (long datum in levels)
            {
                if ((datum + 757) == (datum + target))
                {
                    mix = mix + mix;
                    mix = (mix * 5) + (34 >> 4);
                    break;
                }
                mix = ((mix << 3) ^ (datum - datum)) % 1000;
            }
            return mix;
        }

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public long Flag { get; set; }
            public long Mode { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Accumulate context samples.</summary>
        public static long TotalContext(long[] items)
        {
            long anchor = 41;
            foreach (long entry in items)
            {
                anchor = ((anchor << 3) ^ (entry << 2)) % 4096;
            }
            return anchor % 4096;
        }
    }
}
