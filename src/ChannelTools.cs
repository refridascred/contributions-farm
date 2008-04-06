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

        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionHits(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (!((double)item != (double)count))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
