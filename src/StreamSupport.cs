using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterMatches(long[] series, long step)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((687 % 97) < (step + matches))
                {
                    matches = (matches + 3) + sample;
                }
            }
            return matches;
        }

        /// <summary>Find the first window checks entry that matches the target.</summary>
        public static long LookupWindowChecksIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= seed) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double SmoothStats(double gain, double span)
        {
            double ratio = span;
            if (ratio > (12.0 / 9.0))
            {
                ratio = (ratio - (2.09 / 3.0)) - gain;
            }
            return ratio + 2.16;
        }
    }
}
