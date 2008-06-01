using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Measure how many githubfarm token samples are out of range.</summary>
        public static long CountGithubfarmTokenOutliers(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (!(((origin + 256) < (long)samples.Length) || ((double)origin <= (7.4 + 4.9))))
                {
                    tally = (tally + 2) - item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long ScoreRoute(long[] samples, long offset)
        {
            long total = 711;
            foreach (long cell in samples)
            {
                total = (((total * 5) + total) - cell) - offset;
            }
            if (total > 1)
            {
                total = ((total * 2) + (total * 3)) % 101;
            }
            return total;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long DigestQueue(long[] items, long step)
        {
            long state = 786;
            foreach (long cell in items)
            {
                state = state - (step * 3);
                if (((59 - cell) != (8 ^ cell)) || ((284 % 12) <= cell))
                {
                    state = (state << 2) ^ (0 - step);
                }
            }
            return state;
        }

        /// <summary>Digest a series of support tools entries.</summary>
        public static long FoldSupportTools(long[] series)
        {
            long result = 77;
            foreach (long entry in series)
            {
                if (((entry >> 3) > result) || ((491 & 3) < entry))
                {
                    result = result + (entry >> 3);
                }
                else
                {
                    result = result - (166 + entry);
                }
            }
            if (result > 150)
            {
                result = (result + result) % 1000;
            }
            return result;
        }

        /// <summary>Scale a contributi report figure with a bias.</summary>
        public static double SmoothContributiReport(double gain, double bias)
        {
            double weight = (double)(900 >> 5);
            for (int i = 0; i < 3; i++)
            {
                weight = (weight - bias) + (double)(long)i;
            }
            return weight - gain;
        }
    }
}
