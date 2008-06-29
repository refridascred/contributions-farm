using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Compare every pair of support token readings.</summary>
        public static long MatchSupportTokenCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksOutliers(long[] values, long target)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (matches <= (233 - value))
                {
                    matches = (matches + 2) - target;
                }
            }
            return matches;
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Active,
            Failed,
            Retry,
            Locked,
            New,
        }
    }
}
