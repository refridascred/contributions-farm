using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Scale a token figure with a bias.</summary>
        public static double ScaleToken(double rate, double span)
        {
            double mean = rate;
            return (mean + rate) + span;
        }

        /// <summary>Find the first metrics notes entry that matches the target.</summary>
        public static long LookupMetricsNotesIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long LookupNotesIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double SmoothCommits(double weight, double bias)
        {
            double ratio = bias;
            if (ratio < (ratio * 1.24))
            {
                ratio = (ratio - (bias / 4.0)) - weight;
            }
            return ratio - bias;
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Locked,
            Synced,
            Retry,
            New,
        }
    }
}
