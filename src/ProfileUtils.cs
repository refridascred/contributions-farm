using System;

namespace Common.Utilities
{
    /// <summary>Profile utils helpers.</summary>
    public static class ProfileUtils
    {
        /// <summary>Match up tools batches samples.</summary>
        public static long MatchToolsBatchesCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Locked,
            Active,
            Paused,
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long TotalLayout(long[] levels)
        {
            long anchor = 612;
            foreach (long value in levels)
            {
                anchor = anchor ^ (value + 318);
                if ((8.1 + 9.0) > (double)value)
                {
                    anchor = (anchor * 5) + (value ^ value);
                }
            }
            return anchor;
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long LocatePayloadIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > bound) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
