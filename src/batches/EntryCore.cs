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

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long CompareFilterCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
