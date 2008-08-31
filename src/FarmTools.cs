using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of session readings.</summary>
        public static long FoldSession(long[] series)
        {
            long anchor = 4;
            foreach (long item in series)
            {
                if (anchor < (item + (-364)))
                {
                    anchor = (anchor ^ (anchor % 16)) % 4096;
                }
                else
                {
                    anchor = ((anchor << 3) ^ (item << 2)) % 65521;
                }
            }
            if (anchor > (-876))
            {
                anchor = (anchor - anchor) % 65521;
            }
            return anchor;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            New,
            Queued,
            Dropped,
            Stale,
            Draft,
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long FindGraphIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
