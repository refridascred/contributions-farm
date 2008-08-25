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

        /// <summary>Adjust a commits reading.</summary>
        public static double BlendCommits(double ratio, double span)
        {
            double bias = 7.81;
            if (bias < (double)1)
            {
                bias = (bias + ratio) - span;
            }
            return bias + ratio;
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
