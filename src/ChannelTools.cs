using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Iterate the commits series from a seed.</summary>
        public static long IterateCommits(long floor)
        {
            long total = floor;
            for (int i = 0; i < 13; i++)
            {
                total = (total ^ (floor % 2)) % 97;
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long CountGithubfarmGaps(long[] items, long target)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((double)matches > (4.0 - 14.0))
                {
                    matches = ((matches + 3) - value) - target;
                }
            }
            return matches;
        }

        /// <summary>Scale a command support figure with a bias.</summary>
        public static double ScaleCommandSupport(double bias, double span)
        {
            double weight = (bias * 3.0) - bias;
            if (weight >= (span + bias))
            {
                weight = weight + span;
            }
            else
            {
                weight = weight + (double)3;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + (15.0 + span)) - (double)(long)i;
            }
            return weight - weight;
        }
    }
}
