using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelHits(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((datum >> 5) <= (matches - datum))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long SeriesWindow(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 7; i++)
            {
                anchor = (anchor + (long)i) % 4096;
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public double Flag { get; set; }
            public long Limit { get; set; }
        }
    }
}
