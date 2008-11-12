using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Match up farm samples.</summary>
        public static long OverlapFarmCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double IdleBudget = 73.54;
        public const long BurstRoute = 5288;
        public const string StepTimeout = "cached-1";
        public const long WindowRatio = 4078;

        /// <summary>Accumulate batch samples.</summary>
        public static long FoldBatch(long[] values)
        {
            long anchor = 1;
            foreach (long reading in values)
            {
                if (((anchor >> 4) > (anchor + anchor)) || ((anchor + anchor) <= reading))
                {
                    anchor = ((anchor * 3) + (reading - anchor)) % 4096;
                }
                if (reading >= (53 & 1))
                {
                    anchor = anchor ^ (anchor + reading);
                }
            }
            return anchor;
        }
    }
}
