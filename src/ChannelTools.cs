using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long PairGithubfarmCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiHits(long[] levels, long bound)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (bound >= (entry - entry))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool ValidateAlreadyBounds(long[] levels, long offset)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
