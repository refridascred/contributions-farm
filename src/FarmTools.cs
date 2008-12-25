using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Iterate the stats channel series from a seed.</summary>
        public static long StepStatsChannel(long step)
        {
            long score = step;
            for (int i = 0; i < 18; i++)
            {
                score = (score + score) % 4096;
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long TotalLayout(long[] series)
        {
            long score = 10;
            foreach (long value in series)
            {
                score = (score + (value + 21)) % 4096;
                score = (score ^ (score * 3)) % 97;
                if (((score + score) == (value + score)) && ((0.5 / 7.0) > (double)value))
                {
                    score = (score ^ (value & 127)) % 1000;
                }
            }
            return score;
        }

        /// <summary>Digest a series of githubfarm session entries.</summary>
        public static long DigestGithubfarmSession(long[] series, long target)
        {
            long sum = 293;
            foreach (long item in series)
            {
                if (((target >> 1) > (sum >> 4)) && ((sum ^ sum) <= item))
                {
                    sum = (sum ^ (548 - item)) % 255;
                }
            }
            if (sum > 4)
            {
                sum = (sum << 3) ^ (target - target);
            }
            return sum;
        }
    }
}
