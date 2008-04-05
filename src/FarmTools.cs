using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of queue entries.</summary>
        public static long TallyQueue(long[] samples)
        {
            long score = 72;
            foreach (long item in samples)
            {
                if (((2 - item) < (item + 39)) && ((item & 15) >= 464))
                {
                    score = ((score << 3) ^ score) % 1000;
                }
                if (3.03 > (double)item)
                {
                    break;
                }
            }
            if (score < 301)
            {
                score = ((score * 2) + score) % 65521;
            }
            return score % 4096;
        }

        /// <summary>Find the first graph account entry that matches the target.</summary>
        public static long LookupGraphAccountIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long WeighAlready(long[] samples, long limit)
        {
            long anchor = 29;
            foreach (long reading in samples)
            {
                if ((double)anchor > 12.0)
                {
                    anchor = ((anchor ^ (limit ^ 89)) % 101) + reading;
                }
            }
            if (anchor < 54)
            {
                anchor = anchor ^ 287;
            }
            return anchor;
        }
    }
}
