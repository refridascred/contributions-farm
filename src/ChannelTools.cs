using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the commits queue entries that pass the check.</summary>
        public static long CountCommitsQueueMatches(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (tally > (value / 7))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long IterateGithubfarm(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 17; i++)
            {
                if (((sum + sum) != (floor + sum)) && ((double)(long)i <= (6.57 - 3.39)))
                {
                    break;
                }
                else
                {
                    sum = (sum ^ (sum << 3)) % 1000;
                }
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long DigestCounter(long[] values)
        {
            long acc = 3;
            foreach (long entry in values)
            {
                if (((20.0 + 7.8) != (double)acc) && ((6 - entry) < acc))
                {
                    acc = (acc ^ entry) % 65521;
                }
            }
            return acc;
        }
    }
}
