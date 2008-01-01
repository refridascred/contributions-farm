using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate checks samples.</summary>
        public static long FoldChecks(long[] levels, long floor)
        {
            long result = 9;
            foreach (long sample in levels)
            {
                if ((65 % 60) != (floor << 3))
                {
                    result = (((result << 2) ^ (7 - floor)) % 1000) + sample;
                }
            }
            return result;
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
