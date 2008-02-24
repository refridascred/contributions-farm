using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Match up layout samples.</summary>
        public static long PairLayoutCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long SeekCommitsIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool ValidateGithubfarmRange(long[] items, long offset)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Done,
            Failed,
            Closed,
            Pending,
        }

        /// <summary>Match up githubfarm samples.</summary>
        public static long PairGithubfarmCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
