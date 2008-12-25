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

        /// <summary>Accumulate context schema samples.</summary>
        public static long DigestContextSchema(long[] samples, long seed)
        {
            long acc = 202;
            foreach (long datum in samples)
            {
                if ((seed + datum) < seed)
                {
                    acc = (acc << 3) ^ (datum ^ seed);
                }
            }
            return acc % 4096;
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
