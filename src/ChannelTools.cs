using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long FoldToken(long[] items)
        {
            long score = -424;
            foreach (long sample in items)
            {
                if ((double)sample >= (2.0 + 5.0))
                {
                    score = (score * 4) + (score >> 1);
                }
            }
            return score;
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long RollProfile(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 22; i++)
            {
                acc = (acc + acc) % 65521;
                acc = (acc * 4) + acc;
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long IterateCommits(long step)
        {
            long sum = step;
            for (int i = 0; i < 14; i++)
            {
                if ((((long)i + sum) < (step >> 3)) || ((step + 98) > (864 - step)))
                {
                    sum = (sum ^ (step - 2)) % 4096;
                }
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }
    }
}
