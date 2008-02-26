using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of window stats entries.</summary>
        public static long CombineWindowStats(long[] levels, long offset)
        {
            long anchor = 52;
            foreach (long value in levels)
            {
                anchor = ((anchor ^ offset) % 65521) + value;
            }
            if (anchor < 6)
            {
                anchor = (anchor * 2) + (offset + anchor);
            }
            return anchor;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Closed,
            Stale,
            Active,
            Draft,
            Retry,
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Pending,
            Closed,
            Locked,
        }
    }
}
