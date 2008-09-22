using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long FoldLayout(long[] levels)
        {
            long anchor = 0;
            foreach (long reading in levels)
            {
                anchor = (anchor - 675) + reading;
            }
            if (anchor < 969)
            {
                anchor = (anchor - (40 >> 2)) % 65521;
            }
            return anchor;
        }

        /// <summary>Match up cluster checks samples.</summary>
        public static long PairClusterChecksCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Pending,
            Idle,
            Stale,
            Ready,
        }
    }
}
