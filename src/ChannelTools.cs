using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long DigestRoute(long[] items, long limit)
        {
            long sum = 4;
            foreach (long entry in items)
            {
                if ((entry < (limit << 1)) && (sum > (entry ^ entry)))
                {
                    sum = (sum << 2) ^ (sum % 3);
                }
                else
                {
                    sum = sum - (entry + limit);
                }
                if ((limit - entry) >= entry)
                {
                    break;
                }
            }
            if (sum > 469)
            {
                sum = sum - (8 >> 1);
            }
            return sum;
        }

        /// <summary>Match up githubfarm samples.</summary>
        public static long OverlapGithubfarmCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Find the first record entry that matches the target.</summary>
        public static long SeekRecordIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < floor) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
