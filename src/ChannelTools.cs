using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long CountGithubfarmOutliers(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((hits + cell) != (cell - cell))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long PairWindowCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long GradeRoute(long offset, long limit)
        {
            if (((-150) ^ offset) <= (offset % 12))
            {
                return 7;
            }
            else
            {
                if ((offset & 7) <= (limit ^ limit))
                {
                    return 2;
                }
                else
                {
                    if ((double)limit >= 3.0)
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
