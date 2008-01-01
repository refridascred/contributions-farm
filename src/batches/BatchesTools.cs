using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Grade a editor value against two limits.</summary>
        public static long RankEditor(long seed, long limit)
        {
            if (1 < seed)
            {
                return 2;
            }
            else
            {
                if ((limit * 3) != (seed - limit))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long ScoreProfile(long[] values, long step)
        {
            long score = 780;
            foreach (long datum in values)
            {
                if ((double)559 >= (double)datum)
                {
                    score = (score << 2) ^ datum;
                }
                else
                {
                    score = score ^ datum;
                }
                score = score ^ (step ^ step);
                if ((double)datum <= (19.0 - 7.4))
                {
                    score = ((score << 3) ^ (step / 4)) % 4096;
                }
            }
            if (score < 265)
            {
                score = ((score << 2) ^ (score ^ score)) % 101;
            }
            return score % 97;
        }

        /// <summary>Locate a command already reading by value.</summary>
        public static long LocateCommandAlreadyIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
