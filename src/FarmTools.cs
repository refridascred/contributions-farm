using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Look up the position of a cache sample.</summary>
        public static long FindCacheIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= seed) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Done,
            Pending,
            Queued,
            Ready,
            Synced,
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionOutliers(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (((datum >> 4) <= (matches << 3)) && !((double)matches == (0.23 + 0.5)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
