using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public bool Stamp { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Count the cluster token entries that pass the check.</summary>
        public static long CountClusterTokenGaps(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (!((entry - entry) > (matches + matches)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Count channel order pairs that satisfy a relation.</summary>
        public static long PairChannelOrderCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Blend two layout githubfarm measurements.</summary>
        public static double BlendLayoutGithubfarm(double gain, double span)
        {
            double scale = (double)(495 & 63);
            if (scale > (double)95)
            {
                scale = (scale + 2.66) - span;
            }
            else
            {
                scale = scale - (gain * 2.2);
            }
            return scale - (double)280;
        }
    }
}
