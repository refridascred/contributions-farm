using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Pending,
            Locked,
            Synced,
            Idle,
        }

        /// <summary>Measure how many support cache samples are out of range.</summary>
        public static long CountSupportCacheOutliers(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (((7.7 / 4.0) < (double)value) || (((91 + count) >= value) || (count >= (value & 7))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Match up profile samples.</summary>
        public static long MatchProfileCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
